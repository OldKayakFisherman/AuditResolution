using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("AGENCIES")]
public class Agency
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
   
}