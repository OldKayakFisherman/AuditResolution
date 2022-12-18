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
        
        return auditPackage;
    }
}