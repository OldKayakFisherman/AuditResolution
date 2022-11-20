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
        public string Audittype { get; set; }

        [JsonProperty("PERIODCOVERED")]
        public string Periodcovered { get; set; }

        [JsonProperty("NUMBERMONTHS")]
        public short? Numbermonths { get; set; }

        [JsonProperty("MULTIPLEEINS")]
        public string Multipleeins { get; set; }

        [JsonProperty("EIN")]
        public string Ein { get; set; }

        [JsonProperty("AUDITEENAME")]
        public string Auditeename { get; set; }

        [JsonProperty("STREET1")]
        public string Street1 { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("ZIPCODE")]
        public string Zipcode { get; set; }

        [JsonProperty("AUDITEECONTACT")]
        public string Auditeecontact { get; set; }

        [JsonProperty("AUDITEETITLE")]
        public string Auditeetitle { get; set; }

        [JsonProperty("AUDITEEPHONE")]
        public string Auditeephone { get; set; }

        [JsonProperty("AUDITEEFAX")]
        public string Auditeefax { get; set; }

        [JsonProperty("AUDITEEEMAIL")]
        public string Auditeeemail { get; set; }

        [JsonProperty("CPAFIRMNAME")]
        public string Cpafirmname { get; set; }

        [JsonProperty("CPASTREET1")]
        public string Cpastreet1 { get; set; }

        [JsonProperty("CPACITY")]
        public string Cpacity { get; set; }

        [JsonProperty("CPASTATE")]
        public string Cpastate { get; set; }

        [JsonProperty("CPAZIPCODE")]
        public string Cpazipcode { get; set; }

        [JsonProperty("CPACONTACT")]
        public string Cpacontact { get; set; }

        [JsonProperty("CPATITLE")]
        public string Cpatitle { get; set; }

        [JsonProperty("CPAPHONE")]
        public string Cpaphone { get; set; }

        [JsonProperty("CPAFAX")]
        public string Cpafax { get; set; }

        [JsonProperty("CPAEMAIL")]
        public string Cpaemail { get; set; }

        [JsonProperty("CPADATESIGNED")]
        public DateTimeOffset Cpadatesigned { get; set; }

        [JsonProperty("COG_OVER")]
        public string CogOver { get; set; }

        [JsonProperty("COGAGENCY")]
        public string Cogagency { get; set; }

        [JsonProperty("COG_AGENCY")]
        public string CogAgency { get; set; }

        [JsonProperty("OVERSIGHTAGENCY")]
        public string Oversightagency { get; set; }

        [JsonProperty("TYPEREPORT_FS")]
        public string TypereportFs { get; set; }

        [JsonProperty("MATERIALNONCOMPLIANCE")]
        public string Materialnoncompliance { get; set; }

        [JsonProperty("GOINGCONCERN")]
        public string Goingconcern { get; set; }

        [JsonProperty("TYPEREPORT_MP")]
        public string TypereportMp { get; set; }

        [JsonProperty("DOLLARTHRESHOLD")]
        public long Dollarthreshold { get; set; }

        [JsonProperty("LOWRISK")]
        public string Lowrisk { get; set; }

        [JsonProperty("TOTFEDEXPEND")]
        public long Totfedexpend { get; set; }

        [JsonProperty("QCOSTS")]
        public string Qcosts { get; set; }

        [JsonProperty("CYFINDINGS")]
        public string Cyfindings { get; set; }

        [JsonProperty("PYSCHEDULE")]
        public string Pyschedule { get; set; }

        [JsonProperty("DUP_REPORTS")]
        public string DupReports { get; set; }

        [JsonProperty("MULTIPLEDUNS")]
        public string Multipleduns { get; set; }

        [JsonProperty("DUNS")]
        public string Duns { get; set; }

        [JsonProperty("AUDITEECERTIFYNAME")]
        public string Auditeecertifyname { get; set; }

        [JsonProperty("AUDITEECERTIFYTITLE")]
        public string Auditeecertifytitle { get; set; }

        [JsonProperty("SIGNIFICANTDEFICIENCY")]
        public string Significantdeficiency { get; set; }

        [JsonProperty("SD_MATERIALWEAKNESS")] 
        public string SdMaterialweakness { get; set; }

        [JsonProperty("SIGNIFICANTDEFICIENCY_MP")] 
        public string SignificantdeficiencyMp { get; set; }

        [JsonProperty("SD_MATERIALWEAKNESS_MP")] 
        public string SdMaterialweaknessMp { get; set; }

        [JsonProperty("SP_FRAMEWORK")] 
        public string SpFramework { get; set; }

        [JsonProperty("SP_FRAMEWORK_REQUIRED")] 
        public string SpFrameworkRequired { get; set; }

        [JsonProperty("TYPEREPORT_SP_FRAMEWORK")] 
        public string TypereportSpFramework { get; set; }

        [JsonProperty("AUDITEE_SUBMIT")] 
        public string AuditeeSubmit { get; set; }

        [JsonProperty("MULTIPLE_CPAS")] 
        public string MultipleCpas { get; set; }

        [JsonProperty("AUDITOR_EIN")] 
        public string AuditorEin { get; set; }

        [JsonProperty("TYPEOFENTITY")] 
        public string Typeofentity { get; set; }

        [JsonProperty("SUPPRESSION_CODE")] 
        public string SuppressionCode { get; set; }

        [JsonProperty("ENTITY_TYPE")] 
        public string EntityType { get; set; }

        [JsonProperty("CPAFOREIGN")] 
        public string Cpaforeign { get; set; }

        [JsonProperty("UEI")] 
        public string Uei { get; set; }

        [JsonProperty("MULTIPLEUEIS")] 
        public string Multipleueis { get; set; }

       

    }
}
