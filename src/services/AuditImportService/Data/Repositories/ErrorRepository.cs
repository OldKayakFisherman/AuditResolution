using AuditImportService.Data.Entities;
using AuditResolution.Common.Extensions;

namespace AuditImportService.Data.Repositories;

public class ErrorRepository
{
    private readonly ApplicationDbContext _ctx;


    public ErrorRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public void AddError(SystemError error)
    {
        _ctx.SystemErrors.Add(error);
        _ctx.SaveChanges();
    }

    public IList<SystemError> GetDailyErrors(DateTime targetDate)
    {
        DateTime startTime = targetDate.ToStartOfDay();
        DateTime endTime = targetDate.ToEndOfDay();

        return _ctx.SystemErrors.Where(x => x.EventDate >= startTime && x.EventDate <= endTime).ToList();

    }

}