using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using GreenLifeOrganicStore.Utils;

namespace GreenLifeOrganicStore.Repositories
{

    public class JsonRepository<T> : IRepository<T> where T : class
    {

        private readonly string _filePath;

        private readonly JavaScriptSerializer _serializer;

        public JsonRepository(string fileName)
        {
            _filePath = FileHelper.GetDataPath(fileName);
            _serializer = new JavaScriptSerializer();
        }

        public List<T> GetAll()
        {
            try
            {
                if (!File.Exists(_filePath)) return new List<T>();
                string json = File.ReadAllText(_filePath);
                if (string.IsNullOrEmpty(json)) return new List<T>();
                return _serializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading data: {ex.Message}");
                return new List<T>();
            }
        }

        public T GetById(string id)
        {
            var all = GetAll();
            return all.FirstOrDefault(x => GetId(x) == id);
        }

        public void Add(T entity)
        {
            var data = GetAll();
            data.Add(entity);
            UpdateAll(data);
        }

        public void Update(T entity)
        {
            var data = GetAll();
            var id = GetId(entity);
            var index = data.FindIndex(x => GetId(x) == id);
            if (index != -1)
            {
                data[index] = entity;
                UpdateAll(data);
            }
        }

        public void Delete(string id)
        {
            var data = GetAll();
            var index = data.FindIndex(x => GetId(x) == id);
            if (index != -1)
            {
                data.RemoveAt(index);
                UpdateAll(data);
            }
        }

        public void UpdateAll(List<T> entities)
        {
            try
            {
                string json = _serializer.Serialize(entities);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
                throw new Exception("Critical Data Error: Could not save changes to disk.", ex);
            }
        }

        private string GetId(T entity)
        {
            // Try common ID property names
            var prop = typeof(T).GetProperty("Id") ?? 
                       typeof(T).GetProperty("ProductId") ?? 
                       typeof(T).GetProperty("OrderId") ?? 
                       typeof(T).GetProperty("ReviewId");
            return prop?.GetValue(entity)?.ToString();
        }
    }
}
