using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportPassthrough
{
    [JsonProperty("ELECAUDITSID")]
    public string ElecAuditsId { get; set; }
    
    [JsonProperty("PASSTHROUGHNAME")]
    public string? PassthroughName { get; set; }
    
    [JsonProperty("PASSTHROUGHID")]
    public string? PassthroughId { get; set; }
}