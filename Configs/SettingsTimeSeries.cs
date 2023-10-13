using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kukoo.Configs
{
    public class SettingsTimeSeries
    {
        
        public string DatabaseName { get; set; }

        public int MaxRetries { get; set; } = 10;
        public int MsBetweenRetries { get; set; } = 300000;
        public string TelemetryTable { get; set; } = "signals";
    }
}
