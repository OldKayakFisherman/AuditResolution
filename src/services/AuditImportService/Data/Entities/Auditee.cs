using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("AUDITEES")]
public class Auditee
{
    [Key, Column("ID")]
    public int Id { get; set; }

    [Column("EIN")] 
    public string? EIN { get; set; }
    
    [Column("NAME")]
    public string? Name { get; set; }

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
    public string? Title { get; set; }

    [Column("PHONE")]
    public string? AuditeePhone { get; set; }

    [Column("FAX")]
    public string? AuditeeFax { get; set; }

    [Column("EMAIL")]
    public string? AuditeeEmail { get; set; }
    
    [Column("UEI")] 
    public string? UEI { get; set; }
    
    [Column("DUNS")]
    public string? DUNS { get; set; }


    public IList<AuditPackage>? AuditPackages { get; set; }

}