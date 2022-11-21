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
    public bool MaterialNonCompliance { get; set; }

    [Column("GOINGCONCERN")]
    public bool GoingConcern { get; set; }

    [Column("TYPEREPORT_MP")]
    public string? TypeReportMajorProgram { get; set; }
    
    [Column("LOWRISK")]
    public bool LowRisk { get; set; }
    
    [Column("QCOSTS")]
    public bool QCosts { get; set; }
    
    [Column("PYSCHEDULE")]
    public bool PriorYearSchedule { get; set; }

    [Column("DUP_REPORTS")]
    public bool DuplicateReports { get; set; }

    [Column("SIGNIFICANTDEFICIENCY")]
    public bool SignificantDeficiency { get; set; }

    [Column("SD_MATERIALWEAKNESS")] 
    public bool SignificantDeficiencyMaterialWeakness { get; set; }

    [Column("SIGNIFICANTDEFICIENCY_MP")] 
    public bool SignificantDeficiencyMajorProgram { get; set; }

    [Column("SD_MATERIALWEAKNESS_MP")] 
    public bool SignificantDeficiencyMaterialWeaknessMajorProgram { get; set; }

    [Column("SP_FRAMEWORK")] 
    public string? SpecialFramework { get; set; }

    [Column("SP_FRAMEWORK_REQUIRED")] 
    public bool SpecialFrameworkFrameworkRequired { get; set; }

    [Column("TYPEREPORT_SP_FRAMEWORK")] 
    public string? TypeReportSpecialFramework { get; set; }

    public int? AuditPackageId { get; set; }
    public AuditPackage? AuditPackage { get; set; }
}