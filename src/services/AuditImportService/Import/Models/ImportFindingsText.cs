using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportFindingsText
{
    [JsonProperty("SEQ_NUMBER")] 
    public short SeqNumber { get; set; }

    [JsonProperty("AUDITYEAR")] 
    public short AuditYear { get; set; }

    [JsonProperty("REPORTID")] 
    public int Reportid { get; set; }

    [JsonProperty("VERSION")] 
    public short Version { get; set; }

    [JsonProperty("FINDINGREFNUMS")] 
    public string FindingRefNums { get; set; }

    [JsonProperty("TEXT")] 
    public string Text { get; set; }

    [JsonProperty("CHARTSTABLES")] 
    public string ChartsTables { get; set; }

    [JsonProperty("ROWID")] 
    public int? RowId { get; set; }
}