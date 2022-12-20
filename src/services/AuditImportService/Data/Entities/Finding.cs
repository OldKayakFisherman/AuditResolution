using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("FINDINGS")]
public class Finding
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("QCOSTS")]
    public bool QuestionedCosts {get;set;}
    
    [Column("OTHERFINDINGS")]
    public bool OtherFindings {get;set;}
    
    [Column("SIGNIFICANTDEFICIENCY")]
    public bool SignificantDeficiency {get;set;}
    
    [Column("MATERIALWEAKNESS")]
    public bool MaterialWeakness {get;set;}
    
    [Column("OTHERNONCOMPLIANCE")]
    public bool OtherNonCompliance {get;set;}
    
    [Column("TYPEREQUIREMENT")]
    public string? TypeRequirement {get;set;}
    
    [Column("FINDINGREFNUMS")]
    public string? FindingRefNums {get;set;}
    
    [Column("MODIFIEDOPINION")]
    public bool ModifiedOpinion {get;set;}
    
    [Column("REPEATFINDING")]
    public bool RepeatFinding { get; set; }
    
    [Column("PRIORFINDINGREFNUMS")] 
    public string? PriorFindingRefNums { get; set; }

    
}