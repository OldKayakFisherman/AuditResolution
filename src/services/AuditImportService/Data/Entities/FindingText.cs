using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;

[Table("FINDING_TEXT")]
public class FindingText
{
    [Key, Column("ID")]
    public int Id { get; set; }

    [Column("SEQ_NUMBER")] 
    public short SeqNumber { get; set; }
    
    [Column("FINDINGREFNUMS")] 
    public string? FindingRefNums { get; set; }

    [Column("TEXT")] 
    public string? Text { get; set; }

    [Column("CHARTSTABLES")] 
    public string? ChartsTables { get; set; }

  
}