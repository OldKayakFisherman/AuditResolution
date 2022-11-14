using AuditResolution.Infrastructure.Configuration;
using TestHelpers;

namespace AuditResolution.Infrastructure.Tests
{
    public class SettingsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSettingUtility()
        {
            AppSettings? settings = AppSettingsHelper.GetAppSettings("appsettings.test.json");

            Assert.IsNotNull(settings);
            Assert.IsNotNull(settings.ImportStartDate);
            Assert.IsNotNull(settings.BaseDataDBKeyUrl);
            Assert.IsNotNull(settings.BaseDataFormUrl);
            Assert.IsNotNull(settings.BaseDataImageUrl);


        }
    }
}