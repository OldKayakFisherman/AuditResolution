using AuditImportService.Configuration;
using AuditImportService.Import.Models;
using Microsoft.Extensions.Options;

namespace AuditImportService.Import.Parsers;

public class DBKeyParser
{
    private readonly HttpClient _client;
    private readonly AppSettings _settings;
    
    public DBKeyParser(HttpClient client, IOptions<AppSettings> settings)
    {
        _client = client;
        _settings = settings.Value;
    }

    public IList<ImportDbKey> ImportDbKeys()
    {
        return null;
    }
}