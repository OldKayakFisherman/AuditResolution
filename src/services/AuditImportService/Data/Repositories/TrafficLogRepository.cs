using AuditImportService.Data.Entities;
using AuditResolution.Common.Extensions;


namespace AuditImportService.Data.Repositories;

public class TrafficLogRepository
{
    private readonly ApplicationDbContext _ctx;
    
    public TrafficLogRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public void AddTrafficLog(TrafficLog log)
    {
        _ctx.TrafficLogs.Add(log);
        _ctx.SaveChanges();
    }

    public IList<TrafficLog> GetDailyTraffic(DateTime targetDate)
    {
        DateTime startTime = targetDate.ToStartOfDay();
        DateTime endTime = targetDate.ToEndOfDay();

        return _ctx.TrafficLogs.Where(x => x.TrafficDate >= startTime && x.TrafficDate <= endTime).ToList();

    }
}