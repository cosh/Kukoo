using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kukoo.Configs
{
    public class SettingsKusto
    {
        public string QueryURL { get; set; }

        public string DatabaseName { get; set; }

        public int MaxRetries { get; set; } = 10;
        public int MsBetweenRetries { get; set; } = 300000;
        public string TelemetryTable { get; set; } = "signals";

        public string SPAppId { get; set; }

        public string SPClientSecret { get; set; }

        public string SPTenantId { get; set; }
    }
}
