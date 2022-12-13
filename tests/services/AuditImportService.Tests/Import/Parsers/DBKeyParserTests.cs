using System;
using System.Net.Http;
using System.Threading.Tasks;
using AuditImportService.Configuration;
using AuditImportService.Data;
using AuditImportService.Data.Repositories;
using AuditImportService.Import.Parsers;
using AuditImportService.Import.Parsers.Results;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using TestHelpers;

namespace AuditImportService.Tests.Import.Parsers;

[TestFixture]
public class DBKeyParserTests
{
    [Test]
    public async Task TestParseDBKeys()
    {
        ApplicationDbContext ctx = LocalDBHelper.CreateDbContext();
        HttpClient client = new HttpClientHelper().GetHttpClient();
        FirewallDateRepository firewallDateRepository = new FirewallDateRepository(ctx);
        AppSettings settings = AppSettingsHelper.GetAppSettings<AppSettings>("appsettings.json", "AppSettings")!;
        
        IOptions<AppSettings> options = new OptionsWrapper<AppSettings>(settings);

        DBKeyParser parser = new DBKeyParser(client, options, firewallDateRepository);

        DBKeyParseResult parseResult = await parser.ParseDbKeys(); 
        
        Assert.IsNotNull(await parser.ParseDbKeys());

    }
}