using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OpenProjectDataContext.DataBaseFactory
{
    public interface IDatabaseAdapter
    {
        void CreateDatabase();
        bool ExistsDatabase();
        IDbConnection GetConnection();
        IDbConnection GetConnection(string connectionString);
        string ConnectionString { get; set; }
    }
}
