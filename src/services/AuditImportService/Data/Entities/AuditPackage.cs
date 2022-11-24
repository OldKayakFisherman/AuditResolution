using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("AUDIT_PACKAGES")]
public class AuditPackage
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("AUDIT_YEAR")] 
    public short AuditYear { get; set; }

    [Column("FAC_DBKEY")] 
    public int FACDBKey { get; set; }

    [Column("FAC_REPORTID")] 
    public int FACReportId { get; set; }
    
    [Column("FAC_VERSION")]
    public short Version { get; set; }
    
    [Column("AUDITTYPE")]
    public string? Audittype { get; set; }

    [Column("PERIODCOVERED")]
    public string? Periodcovered { get; set; }

    [Column("NUMBERMONTHS")]
    public short? Numbermonths { get; set; }
    
    [Column("CPADATESIGNED")]
    public DateTime CPADateSigned { get; set; }
    
    [Column("AUDITEECERTIFYNAME")]
    public string? AuditeeCertifyName { get; set; }

    [Column("AUDITEECERTIFYTITLE")]
    public string? AuditeeCertifyTitle { get; set; }
    
    [Column("COG")]
    public string? COG { get; set; }
    
    [Column("COG_AGENCY")]
    public string? COGAgency { get; set; }
    
    [Column("DOLLARTHRESHOLD")]
    public long DollarThreshold { get; set; }

    [Column("TOTFEDEXPEND")]
    public long TotalFederalExpendature { get; set; }

    [Column("TYPEOFENTITY")] 
    public string? TypeOfEntity { get; set; }

    [Column("SUPPRESSION_CODE")] 
    public string? SuppressionCode { get; set; }

    [Column("ENTITY_TYPE")] 
    public string? EntityType { get; set; }

    
    public Auditee? Auditee { get; set; }
    public CPA? CPA { get; set; }
    public AuditTimeframe? AuditTimeframe { get; set; }
    public AuditIndicators? AuditIndicators { get; set; }

    public IList<Award>? Awards { get; set; }
    public IList<CAPText> CapText { get; set; }
    public IList<FindingText> FindingTexts { get; set; }
    public IList<AdditionalEIN> AddtionalEINs { get; set; }
    public IList<AdditionalDUN> AddtionalDUNs { get; set; }
    public IList<AdditionalUEI> AdditionalUEIs { get; set; }
    public IList<Passthrough> Passthroughs { get; set; }
    public IList<ReportedAgency> ReportedAgencies { get; set; }
    public IList<ReportRevision> ReportRevisions { get; set; }

}