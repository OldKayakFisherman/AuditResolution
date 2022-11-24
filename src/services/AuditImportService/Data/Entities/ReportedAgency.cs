using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

public class ReportedAgency
{
    [Key, Column("ID")]
    public int Id { get; set; }
    
    [Column("AGENCYCFDA")]
    public string? Agencycfda { get; set; }

    [Column("PYAGENCY")]
    public string? PyAgency { get; set; }

    [Column("PRIORFINDING")]
    public string? PriorFinding { get; set; }

    [Column("CURRENTFINDING")]
    public string? Currentfinding { get; set; }

    [Column("FINAL")]
    public string? Final { get; set; }

}