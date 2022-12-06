using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;

namespace AuditImportService.Services.Results;

public class SystemStatusResult
{
   
    public IList<SystemError> CurrentErrors { get; set; } = new List<SystemError>();
    public IList<TrafficLog> CurrentTraffic { get; set; } = new List<TrafficLog>();

    public SystemStatusResult() { }

   

}