using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportFACHistory
{
    [JsonProperty("AUDITYEAR")]
    public string? Audityear { get; set; }

    [JsonProperty("REPORTID")]
    public string? Reportid { get; set; }

    [JsonProperty("VERSION")]
    public string? Version { get; set; }

    [JsonProperty("AUDITEE_SUBMIT")]
    public string? AuditeeSubmit { get; set; }

    [JsonProperty("AUDITEE_SUBMIT_DATE")]
    public string? AuditeeSubmitDate { get; set; }

    [JsonProperty("AUDITOR_SUBMIT")]
    public string? AuditorSubmit { get; set; }

    [JsonProperty("AUDITOR_SUBMIT_DATE")]
    public string? AuditorSubmitDate { get; set; }

    [JsonProperty("FAC_SUBMIT")]
    public string? FACSubmit { get; set; }
}