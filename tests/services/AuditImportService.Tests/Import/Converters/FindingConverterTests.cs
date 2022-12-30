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
using AuditResolution.Common.Extensions;


namespace AuditImportService.Tests.Import.Converters;

[TestFixture]
public class FindingConverterTests
{
    [Test]
    public async Task TestConvert()
    {
        ApplicationDbContext ctx = LocalDBHelper.CreateDbContext();
        DbKeyImportLogRepository dbKeyImportLogRepository = new DbKeyImportLogRepository(ctx);
        HttpClient client = new HttpClientHelper().GetHttpClient();
        AppSettings settings = AppSettingsHelper.GetAppSettings<AppSettings>("appsettings.json", "AppSettings")!;
        
        IOptions<AppSettings> options = new OptionsWrapper<AppSettings>(settings);
        
        IList<DBKeyImportLog> logs = LocalDataHelper.GetFindingDbKeyImportLogData();
        ((List<DBKeyImportLog>)logs).ForEach (x => dbKeyImportLogRepository.AddImportLogRecord(x));
        
        FormDataParser parser = new FormDataParser(client, options, dbKeyImportLogRepository);
        
        IList<ImportAuditPackage> packages = await parser.ImportFormData();

        Assert.IsTrue(packages.Count > 0);
        
        foreach (ImportAuditPackage importAuditPackage in packages)
        {
            
            Assert.NotNull(importAuditPackage.Awards);
            
            foreach (ImportAward importAward in importAuditPackage.Awards.Where(x => x.FindingsCount != null).ToList())
            {
                IList<Finding>? findings = new FindingConverter().Convert(importAuditPackage.Findings, importAward.ElecauditsId);

                if (findings != null)
                {
                    Assert.NotNull(findings);
                    Assert.True(findings.Any());
                    Assert.True(!string.IsNullOrEmpty(findings[0].FindingRefNums));
                }
            }
        }
        
    }
}