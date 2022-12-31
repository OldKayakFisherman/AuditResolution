using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AuditImportService.Configuration;
using AuditImportService.Data;
using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;
using AuditImportService.Import.Converters;
using AuditImportService.Import.Models;
using AuditImportService.Import.Parsers;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using TestHelpers;

namespace AuditImportService.Tests.Import.Converters;

[TestFixture]
public class PassthroughConverterTests
{
    [Test]
    public async Task TestConvert()
    {
        ApplicationDbContext ctx = LocalDBHelper.CreateDbContext();
        DbKeyImportLogRepository dbKeyImportLogRepository = new DbKeyImportLogRepository(ctx);
        HttpClient client = new HttpClientHelper().GetHttpClient();
        AppSettings settings = AppSettingsHelper.GetAppSettings<AppSettings>("appsettings.json", "AppSettings")!;
        
        IOptions<AppSettings> options = new OptionsWrapper<AppSettings>(settings);
        
        IList<DBKeyImportLog> logs = LocalDataHelper.GetPassthroughDbKeyImportLogData();
        ((List<DBKeyImportLog>)logs).ForEach (x => dbKeyImportLogRepository.AddImportLogRecord(x));
        
        FormDataParser parser = new FormDataParser(client, options, dbKeyImportLogRepository);
        
        IList<ImportAuditPackage> packages = await parser.ImportFormData();

        Assert.IsTrue(packages.Count > 0);
        
        foreach (ImportAuditPackage importAuditPackage in packages)
        {
            IList<Passthrough>? passthroughs = new PassthroughConverter().Convert(importAuditPackage);
            Assert.NotNull(passthroughs);
            Assert.True(passthroughs.Any());
        }
        
    }
}