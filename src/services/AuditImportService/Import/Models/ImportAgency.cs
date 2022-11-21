using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportAgency
{
    [JsonProperty("CFDAPREFIX")]
    public string? CFDAPrefix { get; set; }

    [JsonProperty("NAME")]
    public string? Name { get; set; }

    [JsonProperty("STARTEXT")]
    public string? StartExt { get; set; }

    [JsonProperty("ENDEXT")]
    public string? EndExt { get; set; }
}