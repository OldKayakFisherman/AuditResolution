using System.Text.Encodings.Web;
using AuditImportService.Configuration;
using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;
using AuditImportService.Import.Models;
using AuditImportService.Import.Parsers.Results;
using Microsoft.Extensions.Options;
using AuditResolution.Common;
using AuditResolution.Common.Extensions;
using Microsoft.AspNetCore.Razor.Language;
using System.Net;
using Newtonsoft.Json;

namespace AuditImportService.Import.Parsers;

public class DBKeyParser
{
    private readonly HttpClient _client;
    private readonly AppSettings _settings;
    private readonly FirewallDateRepository _firewallDateRepository;
    public DBKeyParser(
        HttpClient client, 
        IOptions<AppSettings> settings,
        FirewallDateRepository firewallDateRepository)
    {
        _client = client;
        _settings = settings.Value;
        _firewallDateRepository = firewallDateRepository;
    }

    public async Task<DBKeyParseResult> ParseDBKeys()
    {
        DBKeyParseResult result = new DBKeyParseResult();

        result.ParseDate = DateTime.Now;

        IList<DateTime> datesToParse = CalculateFirewallRequestDates();

        if (datesToParse != null && datesToParse.Count > 0)
        {
            foreach (var firewallDate in datesToParse)
            {

                string requestUrl =
                    $"{_settings.BaseDataDBKeyUrl}?firewallDate={WebUtility.HtmlEncode(firewallDate.ToShortDateString())}";

                HttpResponseMessage response = await _client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (!String.IsNullOrEmpty(responseBody))
                    {
                        IList<ImportDbKey>? importDbKeys =
                            JsonConvert.DeserializeObject<IList<ImportDbKey>>(responseBody);

                        if (importDbKeys != null)
                        {
                            DBKeyParseRecord dbKeyParseRecord = new DBKeyParseRecord();
                            dbKeyParseRecord.ParsedFirewallDate = firewallDate;
                            
                            foreach (var dbKey in importDbKeys)
                            {
                                dbKeyParseRecord.ParsedDBKeyAuditYears.Add(
                                    new Tuple<int, short>(dbKey.DbKey, dbKey.AuditYear)
                                    );
                            }
                        }
                    }
                }



            }
        }

        return result;
    }

    private IList<DateTime> CalculateFirewallRequestDates()
    {
        DateTime importStart = DateTime.Today;
        FirewallDays? lastImportDay = _firewallDateRepository.GetLatestFirewallDate();
        IList<DateTime> datesToImport = new List<DateTime>();
        var batchSize = _settings.BatchDayLimit.HasValue ? _settings.BatchDayLimit.Value: 5;

        if (lastImportDay != null)
        {
            importStart = lastImportDay.FACFirewallDate.NextDay();

           
            if (importStart.NextDay() < DateTime.Now)
            {
                datesToImport.Add(importStart);
                    
                for (int i = 1; i<batchSize; i++)
                {
                    datesToImport.Add(importStart.NextDay());
                }
            }
            else
            {
                DateTime seedDate = importStart;

                while (seedDate <= DateTime.Now)
                {
                    datesToImport.Add(seedDate);
                    seedDate = seedDate.NextDay();
                }
            }
            
        }
        else
        {
            DateTime seedDate = _settings.ImportStartDate.HasValue
                ? _settings.ImportStartDate.Value
                : new DateTime(2016, 1, 4);

            for (int i = 1; i <= batchSize; i++)
            {
                datesToImport.Add(seedDate);
                seedDate = seedDate.NextDay();
            }
        }

        return datesToImport;
    }
}