using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("FEDERAL_AGENCIES")]
public class Agency
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("CFDAPREFIX")]
    public string? CFDAPrefix { get; set; }

    [Column("NAME")]
    public string? Name { get; set; }

    [Column("STARTEXT")]
    public string? StartExt { get; set; }

    [Column("ENDEXT")]
    public string? EndExt { get; set; }
   
}