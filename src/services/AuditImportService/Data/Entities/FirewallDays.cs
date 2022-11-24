using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("FIREWALL_DAYS")]
public class FirewallDays
{
    [Key, Column("ID")]
    public int Id { get; set; }

    [Column("FAC_FIREWALL_DATE")]
    public DateTime FACFirewallDate { get; set; }

    [Column("SYSTEM_IMPORT_DATE")]
    public DateTime SystemImportDate { get; set; }

    [Column("RECORDS_IMPORTED")]
    public short RecordsImported { get; set; }
}