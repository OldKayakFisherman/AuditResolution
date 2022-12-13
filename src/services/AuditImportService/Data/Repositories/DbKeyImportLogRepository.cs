using AuditImportService.Data.Entities;


namespace AuditImportService.Data.Repositories;

public class DbKeyImportLogRepository
{
    private readonly ApplicationDbContext _ctx;
    
    public DbKeyImportLogRepository(ApplicationDbContext ctx)
    {
        _ctx = ctx;
    }

    public void AddImportLogRecord(DBKeyImportLog log)
    {
        _ctx.DbKeyImportLogs.Add(log);
        _ctx.SaveChanges();
    }

    
    public void MarkLogAsImported(int dbKey, short auditYear)
    {
        DBKeyImportLog? log = _ctx.DbKeyImportLogs
            .FirstOrDefault(x => x.DbKey == dbKey && x.AuditYear ==auditYear);

        if (log != null)
        {
            log.DateImported = DateTime.Now;
        }

        _ctx.SaveChanges();
    }

    public IList<DBKeyImportLog> GetUnImportedLogs(int batchSize)
    {
        return _ctx.DbKeyImportLogs.OrderBy(x => x.DateImported)
            .Where(x => x.DateImported == null)
            .Take(batchSize)
            .ToList();
    }

}