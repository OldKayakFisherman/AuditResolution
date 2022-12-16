using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportUEI
{
    [JsonProperty("UEI")]
    public string? UEI { get; set; }
    
    [JsonProperty("SEQNUM")]
    public string? SeqNum { get; set; }
}