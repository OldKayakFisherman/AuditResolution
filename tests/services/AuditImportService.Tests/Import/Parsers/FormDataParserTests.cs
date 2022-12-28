using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AuditImportService.Configuration;
using AuditImportService.Data;
using AuditImportService.Data.Entities;
using AuditImportService.Data.Repositories;
using AuditImportService.Import.Models;
using AuditImportService.Import.Parsers;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using TestHelpers;

namespace AuditImportService.Tests.Import.Parsers;

[TestFixture]
public class FormDataParserTests
{
    [Test]
    public async Task TestImportFormData()
    {
        ApplicationDbContext ctx = LocalDBHelper.CreateDbContext();
        HttpClient client = new HttpClientHelper().GetHttpClient();
        DbKeyImportLogRepository dbKeyImportLogRepository = new DbKeyImportLogRepository(ctx);
        AppSettings settings = AppSettingsHelper.GetAppSettings<AppSettings>("appsettings.json", "AppSettings")!;
        
        IOptions<AppSettings> options = new OptionsWrapper<AppSettings>(settings);

        IList<DBKeyImportLog> logs = LocalDataHelper.GetGeneral2022DBKeyImportLogData();
        ((List<DBKeyImportLog>)logs).ForEach (x => dbKeyImportLogRepository.AddImportLogRecord(x));
        
        FormDataParser parser = new FormDataParser(client, options, dbKeyImportLogRepository);
        
        IList<ImportAuditPackage> packages = await parser.ImportFormData();
        
        Assert.True(packages.Count > 0);
        
    }
}