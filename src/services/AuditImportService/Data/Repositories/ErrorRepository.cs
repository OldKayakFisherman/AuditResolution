using AuditImportService.Data.Entities;

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
        
    }
    
}