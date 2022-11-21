using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("CPAS")]
public class CPA
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("FIRMNAME")]
    public string? Firmname { get; set; }

    [Column("STREET1")]
    public string? Street1 { get; set; }

    [Column("CITY")]
    public string? City { get; set; }

    [Column("STATE")]
    public string? State { get; set; }

    [Column("ZIPCODE")]
    public string? Zipcode { get; set; }

    [Column("CONTACT")]
    public string? Contact { get; set; }

    [Column("TITLE")]
    public string? itle { get; set; }

    [Column("PHONE")]
    public string? Phone { get; set; }

    [Column("FAX")]
    public string? Fax { get; set; }

    [Column("EMAIL")]
    public string? Email { get; set; }
    
    [Column("EIN")] 
    public string? EIN { get; set; }
    
    [Column("FOREIGN")] 
    public bool Foreign { get; set; }

    
    public IList<AuditPackage>? AuditPackages { get; set; }
}