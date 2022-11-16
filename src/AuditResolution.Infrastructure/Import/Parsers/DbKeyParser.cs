using AuditResolution.Infrastructure.Import.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace AuditResolution.Infrastructure.Import.Parsers
{
    public class DbKeyParser
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly JsonSerializerOptions _options;

        public DbKeyParser(IHttpClientFactory httpClientFactory)
        {
            _clientFactory = httpClientFactory;

            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<IList<ImportDbKey>?> ImportDbKeys(string sourceUrl, DateTime firewallDate)
        {
            //Construct the url
            string targetUrl = $"{sourceUrl}?firewallDate={HttpUtility.HtmlEncode(firewallDate.ToShortDateString())}";
            var httpClient = _clientFactory.CreateClient();
            IList<ImportDbKey>? retval = null;

            using (var response = await httpClient.GetAsync(targetUrl, HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();

                retval = await JsonSerializer.DeserializeAsync<List<ImportDbKey>>(stream, _options);
            }


            return retval;
           
        }
    }
}
