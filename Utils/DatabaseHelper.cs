using System;
using System.Configuration;

namespace GreenLifeOrganicStore.Utils
{

    public static class DatabaseHelper
    {

        public static string ConnectionString => ConfigurationManager.ConnectionStrings["GreenLifeDb"]?.ConnectionString 
            ?? @"Server=(localdb)\MSSQLLocalDB;Database=GreenLifeStore;Integrated Security=True;";
    }
}
