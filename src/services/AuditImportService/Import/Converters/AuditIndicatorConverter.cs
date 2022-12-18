using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;

namespace AuditImportService.Import.Converters;

public class AuditIndicatorConverter
{
    public AuditIndicators? Convert(ImportAuditPackage auditPackage)
    {
        AuditIndicators? indicators = null;

        if (auditPackage.Audit != null)
        {
            indicators = new AuditIndicators();

            indicators.QCosts = auditPackage.Audit.QCosts.ConvertFromYNString();
            indicators.DuplicateReports = auditPackage.Audit.DupReports.ConvertFromYNString();
            indicators.GoingConcern = auditPackage.Audit.GoingConcern.ConvertFromYNString();
            indicators.LowRisk = auditPackage.Audit.LowRisk.ConvertFromYNString();
            indicators.SignificantDeficiency = auditPackage.Audit.SignificantDeficiency.ConvertFromYNString();
            indicators.SpecialFramework = auditPackage.Audit.SPFramework;
            indicators.MaterialNonCompliance = auditPackage.Audit.MaterialNonCompliance.ConvertFromYNString();
            indicators.PriorYearSchedule = auditPackage.Audit.PySchedule.ConvertFromYNString();
            indicators.SignificantDeficiencyMajorProgram =
                auditPackage.Audit.SignificantDeficiencyMP.ConvertFromYNString();
            indicators.SignificantDeficiencyMaterialWeakness =
                auditPackage.Audit.SDMaterialWeakness.ConvertFromYNString();
            indicators.SpecialFrameworkFrameworkRequired = auditPackage.Audit.SPFrameworkRequired.ConvertFromYNString();
            indicators.TypeReportFinancialStatements = auditPackage.Audit.TypeReportFS;
            indicators.TypeReportMajorProgram = auditPackage.Audit.TypeReportMP;
            indicators.TypeReportSpecialFramework = auditPackage.Audit.TypeReportSPFramework;
            indicators.SignificantDeficiencyMaterialWeaknessMajorProgram =
                auditPackage.Audit.SDMaterialWeaknessMP.ConvertFromYNString();

        }

        return indicators;
    }
}