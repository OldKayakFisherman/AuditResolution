using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("AUDIT_TIMEFRAMES")]
public class AuditTimeframe
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("AUDITEE_SUBMIT_DATE")]
    public DateTime AuditeeSubmitDate { get; set; }
    
    [Column("AUDITOR_SUBMIT_DATE")]
    public DateTime AuditorSubmitDate { get; set; }
    
    [Column("SYSTEM_IMPORT_DATE")] 
    public DateTime SystemImportDate { get; set; }
    
    [Column("FYENDDATE")]
    public DateTime Fyenddate { get; set; }

    [Column("FYSTARTDATE")]
    public DateTime Fystartdate { get; set; }

    [Column("CPA_DATE_SIGNED")] public DateTime? CPADateSigned { get; set; }

    public int? AuditPackageId { get; set; }
    public AuditPackage? AuditPackage { get; set; }
}