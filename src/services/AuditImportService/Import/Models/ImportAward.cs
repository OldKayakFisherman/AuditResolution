using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportAward
{
        [JsonProperty("CFDASEQNUM")]
        public string CFDASequenceNumber { get; set; }

        [JsonProperty("FEDERALPROGRAMNAME")]
        public string FederalProgramName { get; set; }

        [JsonProperty("AMOUNT")]
        public long Amount { get; set; }

        [JsonProperty("MAJORPROGRAM")]
        public string MajorProgram { get; set; }

        [JsonProperty("TYPEREQUIREMENT")]
        public string TypeRequirement { get; set; }

        [JsonProperty("FINDINGREFNUMS")]
        public string FindingRefNums { get; set; }

        [JsonProperty("RD")]
        public string RD { get; set; }

        [JsonProperty("DIRECT")]
        public string Direct { get; set; }

        [JsonProperty("CFDA_PREFIX")]
        public string CFDAPrefix { get; set; }

        [JsonProperty("CFDA_EXT")]
        public string CFDAExt { get; set; }

        [JsonProperty("TYPEREPORT_MP")]
        public string TypeReportMP { get; set; }

        [JsonProperty("ARRA")]
        public string ARRA { get; set; }

        [JsonProperty("LOANS")]
        public string Loans { get; set; }

        [JsonProperty("ELECAUDITSID")]
        public long ElecauditsId { get; set; }

        [JsonProperty("FINDINGSCOUNT")]
        public int FindingsCount { get; set; }
        
        [JsonProperty("LOANBALANCE")]
        public long LoanBalance { get; set; }

        [JsonProperty("PASSTHROUGHAMOUNT")]
        public long PassthroughAmount { get; set; }

        [JsonProperty("AWARDIDENTIFICATION")]
        public string AwardIdentification { get; set; }

        [JsonProperty("CLUSTERNAME")]
        public string ClusterName { get; set; }

        [JsonProperty("PASSTHROUGHAWARD")]
        public string PassthroughAward { get; set; }

        [JsonProperty("STATECLUSTERNAME")]
        public string StateClustername { get; set; }

        [JsonProperty("PROGRAMTOTAL")]
        public long ProgramTotal { get; set; }

        [JsonProperty("CLUSTERTOTAL")]
        public long ClusterTotal { get; set; }

        [JsonProperty("OTHERCLUSTERNAME")]
        public string OtherClusterName { get; set; }

        [JsonProperty("CFDA_KEY")]
        public string CFDAKey { get; set; }

        [JsonProperty("DEFAULT_PROGRAM_NAME")]
        public string DefaultProgramName { get; set; }

        [JsonProperty("DEFAULT_CLUSTER_NAME")]
        public string DefaultClusterName { get; set; }
        
}