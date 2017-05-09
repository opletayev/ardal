using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardal.Config
{
    public class Configuration
    {
        public Environment Dev { get; set; }
        public Environment Prod { get; set; }
        public Environment Staging { get; set; }
    }

    public class Environment
    {
        public Database Database { get; set; }
        public string Host { get; set; }
        public string Path { get; set; }
        public string LogLevel { get; set; }
    }

    public class Database
    {
        public string Db { get; set; }
        public string Provider { get; set; }
        public Pool Pool { get; set; }
    }

    public class Pool
    {
        public int Active { get; set; }
        public int Max { get; set; }
        public int TTL { get; set; }
    }
}
