using System.Collections.Generic;
using AuditImportService.Data;
using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;
using NUnit.Framework;
using System.Linq;

namespace AuditImportService.Tests.Data;

[TestFixture]
public class DBKeyImportLogRepositoryTests
{
    [Test]
    public void TestDataFlow()
    {
        IList<DBKeyImportLog> logs = LocalDataHelper.GetDBKeyImportLogData();

        using (ApplicationDbContext ctx = LocalDBHelper.CreateDbContext())
        {
            DbKeyImportLogRepository repository = new DbKeyImportLogRepository(ctx);
            
            ((List<DBKeyImportLog>)logs).ForEach (x => repository.AddImportLogRecord(x));

            logs = repository.GetUnImportedLogs(2);
            
            Assert.IsTrue(logs.Count == 2);
            
            logs = repository.GetUnImportedLogs(5);
            
            Assert.IsTrue(logs.Count == 5);
            
            ((List<DBKeyImportLog>)logs).ForEach(x => repository.MarkLogAsImported(x.DbKey, x.AuditYear));
            
            logs = repository.GetUnImportedLogs(5);

            Assert.IsTrue(logs.Count == 0);
            

        }
        
    }
}