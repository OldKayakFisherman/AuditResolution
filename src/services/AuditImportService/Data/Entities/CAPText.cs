using System.ComponentModel.DataAnnotations.Schema;


namespace AuditImportService.Data.Entities;

[Table("CAP_TEXT")]
public class CAPText
{
    [Column("SEQ_NUMBER")] 
    public short SeqNumber { get; set; }
    
    [Column("FINDINGREFNUMS")] 
    public string? Findingrefnums { get; set; }

    [Column("TEXT")] 
    public string? Text { get; set; }

    [Column("CHARTSTABLES")] 
    public string? Chartstables { get; set; }
    
}