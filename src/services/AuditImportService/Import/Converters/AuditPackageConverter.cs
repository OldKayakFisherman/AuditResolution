using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;

namespace AuditImportService.Import.Converters;

public class AuditPackageConverter
{
    public AuditPackage Convert(ImportAuditPackage importAuditPackage)
    {
        AuditPackage auditPackage = new AuditPackage();

        auditPackage.Auditee = new AuditeeConverter().Convert(importAuditPackage);
        auditPackage.AuditIndicators = new AuditIndicatorConverter().Convert(importAuditPackage);
        auditPackage.AuditTimeframe = new AuditTimeframeConverter().Convert(importAuditPackage);
        auditPackage.Awards = new AwardConverter().Convert(importAuditPackage);
        
        if (importAuditPackage.Audit != null && 
            !string.IsNullOrEmpty(importAuditPackage.Audit.Audityear))
        {
            auditPackage.AuditYear = short.Parse(importAuditPackage.Audit.Audityear);
        }

        if (importAuditPackage.Audit != null && 
            !string.IsNullOrEmpty(importAuditPackage.Audit.Audittype))
        {
            auditPackage.Audittype = importAuditPackage.Audit.Audittype;
        }

        auditPackage.CapText = new CAPTextConverter().Convert(importAuditPackage);
        
        

        return auditPackage;
    }
}