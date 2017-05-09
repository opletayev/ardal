using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardal.Config
{
    public class Settings
    {
        public string Path { get; set; }
        public string Environment { get; set; } = "prod";

        public Settings()
        {

        }
    }
}
