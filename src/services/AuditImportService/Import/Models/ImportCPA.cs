using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportCPA
{
    [JsonProperty("CPAFIRMNAME")] 
    public global::System.String CPAFirmName {get;set;}
    
    [JsonProperty("CPASTREET1")]
    public global::System.String CPAStreet1 {get;set;}
    
    [JsonProperty("CPACITY")]
    public global::System.String CPACity {get;set;}
    
    [JsonProperty("CPASTATE")]
    public global::System.String CPAState {get;set;}
    
    [JsonProperty("CPAZIPCODE")]
    public global::System.String CPAZipCode {get;set;}
    
    [JsonProperty("CPACONTACT")]
    public global::System.String CPAContact {get;set;}
    
    [JsonProperty("CPATITLE")]
    public global::System.String CPATitle {get;set;}
    
    [JsonProperty("CPAPHONE")]
    public global::System.String CPAPhone {get;set;}
    
    [JsonProperty("CPAFAX")]
    public global::System.String CPAFax {get;set;}
    
    [JsonProperty("CPAEMAIL")]
    public global::System.String CPAEmail {get;set;}
    
    [JsonProperty("CPAEIN")]
    public global::System.String CPAEIN {get;set;}
}