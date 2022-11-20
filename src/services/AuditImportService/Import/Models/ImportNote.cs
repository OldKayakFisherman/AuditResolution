using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportNote
{
    [JsonProperty("REPORTID")]
    public int Reportid { get; set; }

    [JsonProperty("AUDITYEAR")]
    public short AuditYear { get; set; }

    [JsonProperty("CONTENT")]
    public string Content { get; set; }

    [JsonProperty("ID")]
    public int Id { get; set; }

    [JsonProperty("NOTE_INDEX")]
    public short NoteIndex { get; set; }

    [JsonProperty("SEQ_NUMBER")]
    public short SeqNumber { get; set; }

    [JsonProperty("TITLE")]
    public string Title { get; set; }

    [JsonProperty("TYPE_ID")]
    public int TypeId { get; set; }

    [JsonProperty("VERSION")]
    public short Version { get; set; }
}