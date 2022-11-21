using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportReportRevisions
{
    [JsonProperty("ELECRPTREVISIONID")]
    public int ElecRptRevisionId { get; set; }

    [JsonProperty("REPORTID")]
    public int ReportId { get; set; }

    [JsonProperty("VERSION")]
    public int Version { get; set; }

    [JsonProperty("GENINFO")]
    public string? GenInfo { get; set; }

    [JsonProperty("GENINFO_EXPLAIN")]
    public string? GenInfoExplain { get; set; }

    [JsonProperty("FEDERALAWARDS")]
    public string? FederalAwards { get; set; }

    [JsonProperty("FEDERALAWARDS_EXPLAIN")]
    public string? FederalAwardsExplain { get; set; }

    [JsonProperty("NOTESTOSEFA")]
    public string? NotesToSEFA { get; set; }

    [JsonProperty("NOTESTOSEFA_EXPLAIN")]
    public string? NotesToSEFAExplain { get; set; }

    [JsonProperty("AUDITINFO")]
    public string? AuditInfo { get; set; }

    [JsonProperty("AUDITINFO_EXPLAIN")]
    public string? AuditInfoExplain { get; set; }

    [JsonProperty("FINDINGS")]
    public string? Findings { get; set; }

    [JsonProperty("FINDINGS_EXPLAIN")]
    public string? FindingsExplain { get; set; }

    [JsonProperty("FINDINGSTEXT")]
    public string? FindingsText { get; set; }

    [JsonProperty("FINDINGSTEXT_EXPLAIN")]
    public string? FindingsTextExplain { get; set; }

    [JsonProperty("CAP")]
    public string? CAP { get; set; }

    [JsonProperty("CAP_EXPLAIN")]
    public string? CapExplain { get; set; }

    [JsonProperty("OTHER")]
    public string? Other { get; set; }

    [JsonProperty("OTHER_EXPLAIN")]
    public string? OtherExplain { get; set; }
}