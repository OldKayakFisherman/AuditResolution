using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportCAPText
{
    [JsonProperty("SEQ_NUMBER")] 
    public string? SeqNumber { get; set; }

    [JsonProperty("AUDITYEAR")] 
    public string? AuditYear { get; set; }

    [JsonProperty("REPORTID")] 
    public string? Reportid { get; set; }

    [JsonProperty("VERSION")] 
    public string? Version { get; set; }

    [JsonProperty("FINDINGREFNUMS")] 
    public string? Findingrefnums { get; set; }

    [JsonProperty("TEXT")] 
    public string? Text { get; set; }

    [JsonProperty("CHARTSTABLES")] 
    public string? Chartstables { get; set; }

    [JsonProperty("ROWID")] 
    public string? RowId { get; set; }
}