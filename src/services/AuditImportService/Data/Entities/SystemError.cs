using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuditImportService.Data.Entities;
[Table("SYSTEM_ERRORS")]
public class SystemError
{
    [Key, Column("ID")] 
    public int Id { get; set; }

    [Column("MESSAGE")] 
    public string Message { get; set; } = "System Error";

    [Column("EXCEPTION_TYPE")]
    public string? ExceptionType { get; set; }
    
    [Column("STACK_TRACE")] 
    public string? StackTrace { get; set; }

    [Column("EVENT_DATE")] 
    public DateTime EventDate { get; set; } = DateTime.Now;

    [Column("REQUEST_PATH")] 
    public string? RequestPath { get; set; }

    [Column("REQUEST_HEADERS")] 
    public string? RequestHeaders { get; set; }

    [Column("REMOTE_ADDRESS")] 
    public string? RemoteAddress { get; set; }

    
}