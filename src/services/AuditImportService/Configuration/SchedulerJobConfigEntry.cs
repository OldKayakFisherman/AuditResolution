namespace AuditImportService.Configuration;

public class SchedulerJobConfigEntry
{
    public string? JobNamespace { get; set; }
    public string? JobClass { get; set; }
    public bool Enabled { get; set; }
    public string? CronExpression { get; set; }
    public string? Description { get; set; }
    
}