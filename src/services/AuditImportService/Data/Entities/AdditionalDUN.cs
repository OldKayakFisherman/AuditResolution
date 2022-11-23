using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("ADDITIONAL_DUNS")]
public class AdditionalDUN
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("SEQNUM")] 
    public short SeqNum {get;set;}
  
    [Column("DUNS")]
    public string? DUNs {get;set;}
    
    [Column("MAIN_DUNS")]
    public string? MainDUNs {get;set;}
}