using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("ADDITIONAL_DUNS")]
public class AdditionalUEI
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("UEI")]
    public string? UEI { get; set; }
    
    [Column("SEQNUM")]
    public short? SeqNum { get; set; }
}