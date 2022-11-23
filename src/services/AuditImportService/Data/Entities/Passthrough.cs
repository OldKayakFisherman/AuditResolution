using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;
[Table("PASSTHROUGHS")]
public class Passthrough
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("PASSTHROUGHNAME")]
    public string? PassthroughName { get; set; }
    
    [Column("PASSTHROUGHID")]
    public string? PassthroughId { get; set; }
}