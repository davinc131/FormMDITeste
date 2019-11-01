using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace OpenProjectDataContext.DataBaseFactory
{
    public class DatabaseAdapterSQLite: IDatabaseAdapter
    {
        static string FileNameDb = "openprojectbrgaap.db";

        public DatabaseAdapterSQLite()
        {
        }

        public string ConnectionString { get; set; } = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FileNameDb)};Version=1;Read Only=False;";

        public void CreateDatabase()
        {
            try
            {
                if (!File.Exists(FileNameDb))
                    SQLiteConnection.CreateFile(FileNameDb);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ExistsDatabase()
        {
            return File.Exists(FileNameDb);
        }

        public IDbConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public IDbConnection GetConnection(string connectionString)
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
