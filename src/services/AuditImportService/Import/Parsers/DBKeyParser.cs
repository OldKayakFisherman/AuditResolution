using AuditImportService.Import.Models;

namespace AuditImportService.Import.Parsers;

public class DBKeyParser
{
    private readonly HttpClient _client;
    
    public DBKeyParser(HttpClient client)
    {
        _client = client;
    }

    public IList<ImportDbKey> ImportDbKeys()
    {
        return null;
    }
}