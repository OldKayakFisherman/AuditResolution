using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("AUDIT_INDICATORS")]
public class AuditIndicators
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("TYPEREPORT_FS")]
    public string? TypeReportFinancialStatements { get; set; }

    [Column("MATERIALNONCOMPLIANCE")]
    public string? MaterialNonCompliance { get; set; }

    [Column("GOINGCONCERN")]
    public string? GoingConcern { get; set; }

    [Column("TYPEREPORT_MP")]
    public string? TypeReportMajorProgram { get; set; }
    
    [Column("LOWRISK")]
    public string? LowRisk { get; set; }
    
    [Column("QCOSTS")]
    public string? QCosts { get; set; }

    [Column("CYFINDINGS")]
    public string? CurrentYearFindings { get; set; }

    [Column("PYSCHEDULE")]
    public string? PriorYearSchedule { get; set; }

    [Column("DUP_REPORTS")]
    public string? DuplicateReports { get; set; }

    [Column("SIGNIFICANTDEFICIENCY")]
    public string? SignificantDeficiency { get; set; }

    [Column("SD_MATERIALWEAKNESS")] 
    public string? SignificantDeficiencyMaterialWeakness { get; set; }

    [Column("SIGNIFICANTDEFICIENCY_MP")] 
    public string? SignificantDeficiencyMajorProgram { get; set; }

    [Column("SD_MATERIALWEAKNESS_MP")] 
    public string? SignificantDeficiencyMaterialWeaknessMajorProgram { get; set; }

    [Column("SP_FRAMEWORK")] 
    public string? SpecialFramework { get; set; }

    [Column("SP_FRAMEWORK_REQUIRED")] 
    public string? SpecialFrameworkFrameworkRequired { get; set; }

    [Column("TYPEREPORT_SP_FRAMEWORK")] 
    public string? TypeReportSpecialFramework { get; set; }

    public int? AuditPackageId { get; set; }
    public AuditPackage? AuditPackage { get; set; }
}