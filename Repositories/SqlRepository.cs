using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using GreenLifeOrganicStore.Utils;

namespace GreenLifeOrganicStore.Repositories
{

    public class SqlRepository<T> : IRepository<T> where T : class, new()
    {

        private string _tableName;

        private string _idPropertyName;

        public SqlRepository(string tableName, string idPropertyName = "Id")
        {
            _tableName = tableName;
            _idPropertyName = idPropertyName;
        }

        public List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = $"SELECT * FROM {_tableName}";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(MapReaderToObject(reader));
                }
            }
            return list;
        }

        public T GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = $"SELECT * FROM {_tableName} WHERE {_idPropertyName} = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return MapReaderToObject(reader);
                }
            }
            return null;
        }

        public void Add(T entity)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => IsSimpleType(p.PropertyType))
                    .ToList();
                string columns = string.Join(", ", properties.Select(p => p.Name));
                string values = string.Join(", ", properties.Select(p => "@" + p.Name));
                string query = $"INSERT INTO {_tableName} ({columns}) VALUES ({values})";
                SqlCommand cmd = new SqlCommand(query, conn);
                foreach (var prop in properties)
                {
                    cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(entity) ?? DBNull.Value);
                }
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(T entity)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => IsSimpleType(p.PropertyType) && p.Name != _idPropertyName)
                    .ToList();
                string setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));
                string query = $"UPDATE {_tableName} SET {setClause} WHERE {_idPropertyName} = @IdParam";
                SqlCommand cmd = new SqlCommand(query, conn);
                foreach (var prop in properties)
                {
                    cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(entity) ?? DBNull.Value);
                }
                var idProp = typeof(T).GetProperty(_idPropertyName);
                cmd.Parameters.AddWithValue("@IdParam", idProp.GetValue(entity));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                string query = $"DELETE FROM {_tableName} WHERE {_idPropertyName} = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAll(List<T> entities)
        {
            // Simple generic bulk update isn't efficient in direct SQL, 
            // but for parity with JsonRepository, we'll just clear and re-insert or handle individually.
            // For simplicity in a store management system, we often don't need UpdateAll if we use relational logic.
            foreach(var entity in entities)
            {
                var idProp = typeof(T).GetProperty(_idPropertyName);
                var id = idProp.GetValue(entity)?.ToString();
                if (GetById(id) != null)
                    Update(entity);
                else
                    Add(entity);
            }
        }

        private T MapReaderToObject(SqlDataReader reader)
        {
            T obj = new T();
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string colName = reader.GetName(i);
                var prop = properties.FirstOrDefault(p => p.Name.Equals(colName, StringComparison.OrdinalIgnoreCase));
                if (prop != null && !reader.IsDBNull(i))
                {
                    if (prop.PropertyType.IsEnum)
                        prop.SetValue(obj, Enum.ToObject(prop.PropertyType, reader.GetValue(i)));
                    else
                        prop.SetValue(obj, reader.GetValue(i));
                }
            }
            return obj;
        }

        private bool IsSimpleType(Type type)
        {
            return type.IsPrimitive || type.IsValueType || type == typeof(string) || type == typeof(DateTime);
        }
    }
}
