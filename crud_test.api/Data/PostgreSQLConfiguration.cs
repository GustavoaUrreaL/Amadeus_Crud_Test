using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_test.api.Data
{
    public class PostgreSQLConfiguration
    {
        
        public PostgreSQLConfiguration(string connectionString) => ConnectionString = connectionString;

        public string ConnectionString { get; set; }
    }
}
