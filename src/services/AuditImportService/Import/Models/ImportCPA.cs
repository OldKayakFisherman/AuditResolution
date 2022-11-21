using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportCPA
{
    [JsonProperty("CPAFIRMNAME")] 
    public string? CPAFirmName {get;set;}
    
    [JsonProperty("CPASTREET1")]
    public string? CPAStreet1 {get;set;}
    
    [JsonProperty("CPACITY")]
    public string? CPACity {get;set;}
    
    [JsonProperty("CPASTATE")]
    public string? CPAState {get;set;}
    
    [JsonProperty("CPAZIPCODE")]
    public string? CPAZipCode {get;set;}
    
    [JsonProperty("CPACONTACT")]
    public string? CPAContact {get;set;}
    
    [JsonProperty("CPATITLE")]
    public string? CPATitle {get;set;}
    
    [JsonProperty("CPAPHONE")]
    public string? CPAPhone {get;set;}
    
    [JsonProperty("CPAFAX")]
    public string? CPAFax {get;set;}
    
    [JsonProperty("CPAEMAIL")]
    public string? CPAEmail {get;set;}
    
    [JsonProperty("CPAEIN")]
    public string? CPAEIN {get;set;}
}