using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;


namespace AuditImportService.Import.Converters;

public class AuditTimeframeConverter
{
    public AuditTimeframe? Convert(ImportAuditPackage package)
    {
        AuditTimeframe? auditTimeframe = null;

        if (package.Audit != null)
        {
            auditTimeframe = new AuditTimeframe();
            
            auditTimeframe.Fyenddate = package.Audit.Fyenddate.ParseDateTimeOrDefault();
            auditTimeframe.Fystartdate = package.Audit.Fystartdate.ParseDateTimeOrDefault();
            auditTimeframe.SystemImportDate = DateTime.Now;
        }

        if (package.History != null)
        {
            if (auditTimeframe == null)
            {
                auditTimeframe = new AuditTimeframe();
            }

            auditTimeframe.AuditeeSubmitDate = package.History.AuditeeSubmitDate.ParseDateTimeOrDefault();
            auditTimeframe.AuditorSubmitDate = package.History.AuditorSubmitDate.ParseDateTimeOrDefault();

        }

        return auditTimeframe;
    }
}