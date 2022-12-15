namespace AuditImportService.Configuration;

public class AppSettings
{
    public string? BaseDataFormUrl { get; set; }
    public string? BaseDataDBKeyUrl{ get; set; }
    public string? BaseDataImageUrl{ get; set; }
    public string ApplicationVersion { get; set; }
    public DateTime? ImportStartDate { get; set; }
    public int? BatchDayLimit { get; set; }
    public int? BatchImportLimit{ get; set; }
}