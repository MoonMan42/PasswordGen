using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.SQLite;

namespace PasswordLibrary2
{
    public class SQLiteDataAccess
    {
        public static List<PasswordModel> LoadPasswords()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PasswordModel>("SELECT * FROM Password", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;

        }

        public static void SavePassword(PasswordModel password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Password (Password) VALUES (@Password)", password);
            }
        }
    }
}
