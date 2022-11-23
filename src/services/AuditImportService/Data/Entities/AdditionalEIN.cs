using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("ADDITIONAL_EINS")]
public class AdditionalEIN
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("EIN")]
    public string EIN {get;set;}
    
    [Column("SEQNUM")]
    public short SeqNum {get;set;}
   
    [Column("MAIN_EIN")]
    public string? MainEIN {get;set;}
}