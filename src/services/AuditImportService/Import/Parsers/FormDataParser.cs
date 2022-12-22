using System.Net;
using AuditImportService.Configuration;
using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;
using AuditImportService.Import.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace AuditImportService.Import.Parsers;

public class FormDataParser
{
    private readonly HttpClient _client;
    private readonly AppSettings _settings;
    private readonly DbKeyImportLogRepository _dbKeyImportLogRepository;

    public FormDataParser(
        HttpClient client, 
        IOptions<AppSettings> settings,
        DbKeyImportLogRepository dbKeyImportLogRepository
    )
    {
        _client = client;
        _settings = settings.Value;
        _dbKeyImportLogRepository = dbKeyImportLogRepository;
    }

    public async Task<IList<ImportAuditPackage>> ImportFormData()
    {
        int batchImportLimit = _settings.BatchImportLimit ?? 1000;
        
        IList<DBKeyImportLog> unImportedLogs = _dbKeyImportLogRepository.GetUnImportedLogs(batchImportLimit);
        List<ImportAuditPackage> auditPackages = new List<ImportAuditPackage>();

        if (unImportedLogs.Count > 0)
        {
            foreach (var dbKeyImportLog in unImportedLogs)
            {
                string requestUrl =
                    $"{_settings.BaseDataFormUrl}?dbkey={dbKeyImportLog.DbKey}&audityear={dbKeyImportLog.AuditYear}&mode=data";

                HttpResponseMessage response = await _client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    ImportAuditPackage? package = JsonConvert.DeserializeObject<ImportAuditPackage>(responseBody);

                    if (package != null)
                    {
                        package.DbKey = dbKeyImportLog.DbKey;
                        auditPackages.Add(package);
                    }

                }
            }
        }
        
        return auditPackages;
    }
}