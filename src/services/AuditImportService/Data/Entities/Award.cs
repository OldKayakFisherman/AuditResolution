using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table(("AWARDS"))]
public class Award
{
    [Key, Column("ID")]
    public int Id { get; set; }

        [Column("CFDASEQNUM")]
        public string? CFDASequenceNumber { get; set; }

        [Column("FEDERALPROGRAMNAME")]
        public string? FederalProgramName { get; set; }

        [Column("AMOUNT")]
        public decimal Amount { get; set; }

        [Column("MAJORPROGRAM")]
        public bool MajorProgram { get; set; }

        [Column("TYPEREQUIREMENT")]
        public string? TypeRequirement { get; set; }

        [Column("FINDINGREFNUMS")]
        public string? FindingRefNums { get; set; }

        [Column("RD")]
        public bool RD { get; set; }

        [Column("DIRECT")]
        public bool Direct { get; set; }

        [Column("CFDA_PREFIX")]
        public string? CFDAPrefix { get; set; }

        [Column("CFDA_EXT")]
        public string? CFDAExt { get; set; }

        [Column("TYPEREPORT_MP")]
        public string? TypeReportMajorProgram { get; set; }

        [Column("ARRA")]
        public bool ARRA { get; set; }

        [Column("LOANS")]
        public bool Loans { get; set; }
        
        [Column("LOANBALANCE")]
        public long? LoanBalance { get; set; }

        [Column("PASSTHROUGHAMOUNT")]
        public long? PassthroughAmount { get; set; }

        [Column("AWARDIDENTIFICATION")]
        public string? AwardIdentification { get; set; }

        [Column("CLUSTERNAME")]
        public string? ClusterName { get; set; }

        [Column("PASSTHROUGHAWARD")]
        public string? PassthroughAward { get; set; }

        [Column("STATECLUSTERNAME")]
        public string? StateClustername { get; set; }

        [Column("PROGRAMTOTAL")]
        public long? ProgramTotal { get; set; }

        [Column("CLUSTERTOTAL")]
        public long? ClusterTotal { get; set; }

        [Column("OTHERCLUSTERNAME")]
        public string? OtherClusterName { get; set; }

        [Column("CFDA_KEY")]
        public string? CFDAKey { get; set; }

        [Column("DEFAULT_PROGRAM_NAME")]
        public string? DefaultProgramName { get; set; }

        [Column("DEFAULT_CLUSTER_NAME")]
        public string? DefaultClusterName { get; set; }

        public IList<Finding>? Findings { get; set; }
    
}