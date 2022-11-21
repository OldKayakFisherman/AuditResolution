using Newtonsoft.Json;

namespace AuditImportService.Import.Models
{
    public class ImportAudit
    {
        [JsonProperty("AUDITYEAR")]
        public short Audityear { get; set; }

        [JsonProperty("FYENDDATE")]
        public DateTimeOffset Fyenddate { get; set; }

        [JsonProperty("FYSTARTDATE")]
        public DateTimeOffset Fystartdate { get; set; }

        [JsonProperty("AUDITTYPE")]
        public string? Audittype { get; set; }

        [JsonProperty("PERIODCOVERED")]
        public string? Periodcovered { get; set; }

        [JsonProperty("NUMBERMONTHS")]
        public short? Numbermonths { get; set; }

        [JsonProperty("MULTIPLEEINS")]
        public string? MultipleEins { get; set; }

        [JsonProperty("EIN")]
        public string? EIN { get; set; }

        [JsonProperty("AUDITEENAME")]
        public string? AuditeeName { get; set; }

        [JsonProperty("STREET1")]
        public string? Street1 { get; set; }

        [JsonProperty("CITY")]
        public string? City { get; set; }

        [JsonProperty("STATE")]
        public string? State { get; set; }

        [JsonProperty("ZIPCODE")]
        public string? Zipcode { get; set; }

        [JsonProperty("AUDITEECONTACT")]
        public string? AuditeeContact { get; set; }

        [JsonProperty("AUDITEETITLE")]
        public string? AuditeeTitle { get; set; }

        [JsonProperty("AUDITEEPHONE")]
        public string? AuditeePhone { get; set; }

        [JsonProperty("AUDITEEFAX")]
        public string? AuditeeFax { get; set; }

        [JsonProperty("AUDITEEEMAIL")]
        public string? AuditeeEmail { get; set; }

        [JsonProperty("CPAFIRMNAME")]
        public string? CPAFirmname { get; set; }

        [JsonProperty("CPASTREET1")]
        public string? CPAStreet1 { get; set; }

        [JsonProperty("CPACITY")]
        public string? CPACity { get; set; }

        [JsonProperty("CPASTATE")]
        public string? CPAState { get; set; }

        [JsonProperty("CPAZIPCODE")]
        public string? CPAZipcode { get; set; }

        [JsonProperty("CPACONTACT")]
        public string? CPAContact { get; set; }

        [JsonProperty("CPATITLE")]
        public string? CPATitle { get; set; }

        [JsonProperty("CPAPHONE")]
        public string? CPAPhone { get; set; }

        [JsonProperty("CPAFAX")]
        public string? CPAFax { get; set; }

        [JsonProperty("CPAEMAIL")]
        public string? CPAEmail { get; set; }

        [JsonProperty("CPADATESIGNED")]
        public DateTimeOffset CPADateSigned { get; set; }

        [JsonProperty("COG_OVER")]
        public string? COGOver { get; set; }

        [JsonProperty("COGAGENCY")]
        public string? COGAgency { get; set; }

        [JsonProperty("COG_AGENCY")]
        public string? COGAgency2 { get; set; }

        [JsonProperty("OVERSIGHTAGENCY")]
        public string? OversightAgency { get; set; }

        [JsonProperty("TYPEREPORT_FS")]
        public string? TypeReportFS { get; set; }

        [JsonProperty("MATERIALNONCOMPLIANCE")]
        public string? MaterialNonCompliance { get; set; }

        [JsonProperty("GOINGCONCERN")]
        public string? GoingConcern { get; set; }

        [JsonProperty("TYPEREPORT_MP")]
        public string? TypeReportMP { get; set; }

        [JsonProperty("DOLLARTHRESHOLD")]
        public long? DollarThreshold { get; set; }

        [JsonProperty("LOWRISK")]
        public string? LowRisk { get; set; }

        [JsonProperty("TOTFEDEXPEND")]
        public long? TotalFederalExpendature { get; set; }

        [JsonProperty("QCOSTS")]
        public string? QCosts { get; set; }

        [JsonProperty("CYFINDINGS")]
        public string? CyFindings { get; set; }

        [JsonProperty("PYSCHEDULE")]
        public string? PySchedule { get; set; }

        [JsonProperty("DUP_REPORTS")]
        public string? DupReports { get; set; }

        [JsonProperty("MULTIPLEDUNS")]
        public string? MultipleDuns { get; set; }

        [JsonProperty("DUNS")]
        public string? DUNS { get; set; }

        [JsonProperty("AUDITEECERTIFYNAME")]
        public string? AuditeeCertifyName { get; set; }

        [JsonProperty("AUDITEECERTIFYTITLE")]
        public string? AuditeeCertifyTitle { get; set; }

        [JsonProperty("SIGNIFICANTDEFICIENCY")]
        public string? SignificantDeficiency { get; set; }

        [JsonProperty("SD_MATERIALWEAKNESS")] 
        public string? SDMaterialWeakness { get; set; }

        [JsonProperty("SIGNIFICANTDEFICIENCY_MP")] 
        public string? SignificantDeficiencyMP { get; set; }

        [JsonProperty("SD_MATERIALWEAKNESS_MP")] 
        public string? SDMaterialWeaknessMP { get; set; }

        [JsonProperty("SP_FRAMEWORK")] 
        public string? SPFramework { get; set; }

        [JsonProperty("SP_FRAMEWORK_REQUIRED")] 
        public string? SPFrameworkRequired { get; set; }

        [JsonProperty("TYPEREPORT_SP_FRAMEWORK")] 
        public string? TypeReportSPFramework { get; set; }

        [JsonProperty("AUDITEE_SUBMIT")] 
        public string? AuditeeSubmit { get; set; }

        [JsonProperty("MULTIPLE_CPAS")] 
        public string? MultipleCPAs { get; set; }

        [JsonProperty("AUDITOR_EIN")] 
        public string? AuditorEIN { get; set; }

        [JsonProperty("TYPEOFENTITY")] 
        public string? TypeOfEntity { get; set; }

        [JsonProperty("SUPPRESSION_CODE")] 
        public string? SuppressionCode { get; set; }

        [JsonProperty("ENTITY_TYPE")] 
        public string? EntityType { get; set; }

        [JsonProperty("CPAFOREIGN")] 
        public string? CPAForeign { get; set; }

        [JsonProperty("UEI")] 
        public string? UEI { get; set; }

        [JsonProperty("MULTIPLEUEIS")] 
        public string? MultipleUEIs { get; set; }

       

    }
}
