using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("DBKEY_IMPORT_LOG")]
public class DBKeyImportLog
{
    [Key, Column("ID")]
    public int Id { get; set; }

    [Column("DBKEY")] public int DbKey { get; set; }
    [Column("AUDITYEAR")] public short AuditYear { get; set; }
    [Column("DATE_ADDED")] public DateTime DateAdded { get; set; } = DateTime.Now;
    [Column("DATE_IMPORTED")] public DateTime? DateImported { get; set; }
    [Column("PDF_IMPORTED")] public bool PDFImported { get; set; }



}