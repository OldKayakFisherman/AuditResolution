using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportDUN
{
    [JsonProperty("SEQNUM")] 
    public short SeqNum {get;set;}
  
    [JsonProperty("DUNS")]
    public string? DUNs {get;set;}
    
    [JsonProperty("MAIN_DUNS")]
    public string? MainDUNs {get;set;}
   

}