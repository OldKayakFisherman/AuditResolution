using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportNote
{
    [JsonProperty("REPORTID")]
    public string? Reportid { get; set; }

    [JsonProperty("AUDITYEAR")]
    public string? AuditYear { get; set; }

    [JsonProperty("CONTENT")]
    public string? Content { get; set; }

    [JsonProperty("ID")]
    public string? Id { get; set; }

    [JsonProperty("NOTE_INDEX")]
    public string? NoteIndex { get; set; }

    [JsonProperty("SEQ_NUMBER")]
    public string? SeqNumber { get; set; }

    [JsonProperty("TITLE")]
    public string? Title { get; set; }

    [JsonProperty("TYPE_ID")]
    public string? TypeId { get; set; }

    [JsonProperty("VERSION")]
    public string? Version { get; set; }
}