using Kukoo.Configs;
using Kusto.Data;
using Kusto.Data.Common;
using Kusto.Data.Net.Client;
using Microsoft.VisualBasic;
using System.Runtime;

namespace Kukoo.Clients
{
    public class ADXClient
    {
        private IConfiguration _configuration;
        private SettingsKusto _settings;
        public ICslQueryProvider KustoClient;

        public ADXClient(IConfiguration configuration)
        {
            _configuration = configuration;

            _settings = new();
            configuration.GetSection(nameof(SettingsKusto))
                .Bind(_settings);


            KustoConnectionStringBuilder commandsConnectionString;
            if (String.IsNullOrEmpty(_settings.SPAppId))
            {
                commandsConnectionString = new KustoConnectionStringBuilder(_settings.QueryURL).WithAadUserPromptAuthentication();
            }
            else
            {
                commandsConnectionString = new KustoConnectionStringBuilder(_settings.QueryURL).WithAadApplicationKeyAuthentication(_settings.SPAppId, _settings.SPClientSecret, _settings.SPTenantId);
            }

            KustoClient = KustoClientFactory.CreateCslQueryProvider(commandsConnectionString);
        }
    }
}
