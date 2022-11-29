using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;
[Table("SYSTEM_ERRORS")]
public class SystemError
{
    [Key, Column("ID")] 
    public int Id { get; set; }

    [Column("MESSAGE")]
    public string Message { get; set; }

    [Column("STACK_TRACE")] 
    public string? StackTrace { get; set; }

    [Column("EVENT_DATE")] 
    public DateTime EventDate { get; set; } = DateTime.Now;

    [Column("REQUEST_PATH")] 
    public string? RequestPath { get; set; }

    [Column("REQUEST_BODY")] 
    public string RequestBody { get; set; }

    [Column("REMOTE_ADDRESS")] 
    public string? RemoteAddress { get; set; }
    
}