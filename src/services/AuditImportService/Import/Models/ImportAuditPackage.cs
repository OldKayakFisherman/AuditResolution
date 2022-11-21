using Newtonsoft.Json;

namespace AuditImportService.Import.Models
{
    public class ImportAuditPackage
    {
        [JsonProperty("mainEin")]
        public string? MainEin { get; set; }

        [JsonProperty("header")]
        public ImportAudit? Audit { get; set; }

        [JsonProperty("agencyList")] 
        public IList<ImportAgency>? AgencyList { get; set; }

        [JsonProperty("audits")] 
        public IList<ImportAward>? Awards { get; set; }
        
        [JsonProperty("findings")] 
        public IList<ImportAuditFinding>? Findings { get; set; }

        [JsonProperty("additionalEINs")] 
        public IList<ImportEIN>? EINs { get; set; }
        
        [JsonProperty("additionalDUNs")] 
        public IList<ImportDUN>? DUNs { get; set; }
        
        [JsonProperty("additionalCPAs")] 
        public IList<ImportCPA>? CPAs { get; set; }
        
        [JsonProperty("history")] 
        public ImportFACHistory? History { get; set; }
        
        [JsonProperty("passthroughs")] 
        public IList<ImportPassthrough>? Passthroughs { get; set; }
        
        [JsonProperty("reportedAgencies")] 
        public IList<ImportReportedAgency>? ReportedAgencies { get; set; }
        
        [JsonProperty("capTexts")] 
        public IList<ImportCAPText>? CAPTexts { get; set; }
        
        [JsonProperty("findingsTexts")] 
        public IList<ImportCAPText>? FindingsTexts { get; set; }
        
        [JsonProperty("rawElecNotes")]
        public IList<ImportNote>? Notes { get; set; }
        
        [JsonProperty("elecRptRevisions")]
        public IList<ImportReportRevisions>? ReportRevisions { get; set; }
        
        [JsonProperty("additionalUEIS")]
        public IList<ImportUEI>? UEIs { get; set; }
        
        
    }
}
