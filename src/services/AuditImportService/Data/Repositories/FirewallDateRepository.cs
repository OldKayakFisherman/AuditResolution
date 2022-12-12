using AuditImportService.Data.Entities;

namespace AuditImportService.Data.Repositories;

public class FirewallDateRepository
{
    private readonly ApplicationDbContext _ctx;
    
    public FirewallDateRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public FirewallDays? GetLatestFirewallDate()
    {
        return _ctx.FirewallDays.OrderByDescending(x => x.FACFirewallDate)
            .FirstOrDefault();
    }
}