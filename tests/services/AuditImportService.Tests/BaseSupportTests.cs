using AuditImportService.Configuration;
using AuditImportService.Data;
using NUnit.Framework;
using TestHelpers;

namespace AuditImportService.Tests;

[TestFixture]
public class BaseSupportTests
{
    [Test]
    public void TestAppSettings()
    {
        AppSettings? settings = AppSettingsHelper.GetAppSettings<AppSettings>("appsettings.json", "AppSettings");
        
        Assert.IsNotNull(settings);
        Assert.IsNotNull(settings!.ApplicationVersion);
        Assert.IsNotNull(settings!.BaseDataFormUrl);
        Assert.IsNotNull(settings!.BaseDataImageUrl);
        Assert.IsNotNull(settings!.BaseDataDBKeyUrl);
        Assert.IsNotNull(settings!.ImportStartDate);
        Assert.IsNotNull(settings!.BatchDayLimit);
        
    }

    [Test]
    public void TestHttpClient()
    {
        Assert.IsNotNull(new HttpClientHelper().GetHttpClient());
    }

    [Test]
    public void TestInMemoryDatabase()
    {
        ApplicationDbContext ctx = LocalDBHelper.CreateDbContext();
        
        Assert.IsNotNull(ctx);
        Assert.IsTrue(ctx.Database.CanConnect());
        
    }
}