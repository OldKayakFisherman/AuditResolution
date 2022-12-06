using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;
using AuditImportService.Services.Results;

namespace AuditImportService.Services;

public class StatusService
{
    private readonly ErrorRepository _errorRepository;
    private readonly TrafficLogRepository _trafficLogRepository;
    
    public StatusService
    (
        ErrorRepository errorRepository,
        TrafficLogRepository trafficLogRepository
    )
    {
        _errorRepository = errorRepository;
        _trafficLogRepository = trafficLogRepository;
    }

    public SystemStatusResult GetCurrentStatus()
    {
        SystemStatusResult result = new SystemStatusResult();

        result.CurrentTraffic = _trafficLogRepository.GetDailyTraffic(DateTime.Now);
        result.CurrentErrors = _errorRepository.GetDailyErrors(DateTime.Now);
        
        return result;
    }
    
}