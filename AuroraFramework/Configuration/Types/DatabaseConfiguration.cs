using System;
using System.Collections.Generic;
using System.Text;

namespace AuroraFramework.Configuration.Types
{
    public class DatabaseConfiguration : BaseConfiguration
    {
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public DatabaseConfiguration() 
            : base("db.settings.json")
        {
            Server = Get<string>("server");
            Username = Get<string>("username");
            Password = Get<string>("password");
            Database = Get<string>("database");
        }
    }
}
