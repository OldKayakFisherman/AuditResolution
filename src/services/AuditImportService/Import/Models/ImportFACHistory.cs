using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportFACHistory
{
    [JsonProperty("AUDITYEAR")]
    public short Audityear { get; set; }

    [JsonProperty("REPORTID")]
    public int Reportid { get; set; }

    [JsonProperty("VERSION")]
    public short Version { get; set; }

    [JsonProperty("AUDITEE_SUBMIT")]
    public string AuditeeSubmit { get; set; }

    [JsonProperty("AUDITEE_SUBMIT_DATE")]
    public DateTimeOffset AuditeeSubmitDate { get; set; }

    [JsonProperty("AUDITOR_SUBMIT")]
    public string AuditorSubmit { get; set; }

    [JsonProperty("AUDITOR_SUBMIT_DATE")]
    public DateTimeOffset AuditorSubmitDate { get; set; }

    [JsonProperty("FAC_SUBMIT")]
    public string FacSubmit { get; set; }
}