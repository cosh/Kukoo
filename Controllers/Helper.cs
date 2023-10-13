using Kusto.Data.Common;

namespace Kukoo.Controllers
{
    internal class Helper
    {
        internal static ClientRequestProperties CreateClientRequestProperties()
        {
            var crp = new ClientRequestProperties();
            // Set a custom client request identifier
            crp.ClientRequestId = "Kukoo;" + Guid.NewGuid().ToString();
            // Set the query timeout to 1 minute
            crp.SetOption(ClientRequestProperties.OptionServerTimeout, "1m");

            return crp;
        }
    }
}