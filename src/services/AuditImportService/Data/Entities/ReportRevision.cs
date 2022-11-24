using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

public class ReportRevision
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("GENINFO")]
    public string? GenInfo { get; set; }

    [Column("GENINFO_EXPLAIN")]
    public string? GenInfoExplain { get; set; }

    [Column("FEDERALAWARDS")]
    public string? FederalAwards { get; set; }

    [Column("FEDERALAWARDS_EXPLAIN")]
    public string? FederalAwardsExplain { get; set; }

    [Column("NOTESTOSEFA")]
    public string? NotesToSEFA { get; set; }

    [Column("NOTESTOSEFA_EXPLAIN")]
    public string? NotesToSEFAExplain { get; set; }

    [Column("AUDITINFO")]
    public string? AuditInfo { get; set; }

    [Column("AUDITINFO_EXPLAIN")]
    public string? AuditInfoExplain { get; set; }

    [Column("FINDINGS")]
    public string? Findings { get; set; }

    [Column("FINDINGS_EXPLAIN")]
    public string? FindingsExplain { get; set; }

    [Column("FINDINGSTEXT")]
    public string? FindingsText { get; set; }

    [Column("FINDINGSTEXT_EXPLAIN")]
    public string? FindingsTextExplain { get; set; }

    [Column("CAP")]
    public string? CAP { get; set; }

    [Column("CAP_EXPLAIN")]
    public string? CapExplain { get; set; }

    [Column("OTHER")]
    public string? Other { get; set; }

    [Column("OTHER_EXPLAIN")]
    public string? OtherExplain { get; set; }
}