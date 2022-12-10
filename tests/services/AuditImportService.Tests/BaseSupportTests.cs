using AuditImportService.Configuration;
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
        
    }

    [Test]
    public void TestHttpClient()
    {
        Assert.IsNotNull(new HttpClientHelper().GetHttpClient());
    }
}