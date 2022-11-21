using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportAuditFinding
{
    [JsonProperty("QCOSTS")]
    public string? QCosts {get;set;}
    
    [JsonProperty("OTHERFINDINGS")]
    public string? OtherFindings {get;set;}
    
    [JsonProperty("SIGNIFICANTDEFICIENCY")]
    public string? SignificantDeficiency {get;set;}
    
    [JsonProperty("MATERIALWEAKNESS")]
    public string? MaterialWeakness {get;set;}
    
    [JsonProperty("OTHERNONCOMPLIANCE")]
    public string? OtherNonCompliance {get;set;}
    
    [JsonProperty("TYPEREQUIREMENT")]
    public string? TypeRequirement {get;set;}
    
    [JsonProperty("FINDINGREFNUMS")]
    public string? FindingRefNums {get;set;}
    
    [JsonProperty("ELECAUDITSID")]
    public int ElecAuditsId { get; set; }
    
    [JsonProperty("MODIFIEDOPINION")]
    public string? ModifiedOpinion {get;set;}
    
    [JsonProperty("ROWID")]
    public int? RowId { get; set; }
    
    [JsonProperty("REPEATFINDING")]
    public string? RepeatFinding { get; set; }
    
    [JsonProperty("PRIORFINDINGREFNUMS")] 
    public string? PriorFindingRefNums { get; set; }


}