using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportEIN
{

    [JsonProperty("EIN")]
    public string? EIN {get;set;}
    
    [JsonProperty("SEQNUM")]
    public string? SeqNum {get;set;}
   
    [JsonProperty("MAIN_EIN")]
    public string? MainEIN {get;set;}
    
}