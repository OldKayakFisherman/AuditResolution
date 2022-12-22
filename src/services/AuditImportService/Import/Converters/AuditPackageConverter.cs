using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;

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
        auditPackage.CapText = new CAPTextConverter().Convert(importAuditPackage);
        auditPackage.CPA = new CPAConverter().Convert(importAuditPackage);
        auditPackage.FindingTexts = new FindingTextConverter().Convert(importAuditPackage);
        auditPackage.Passthroughs = new PassthroughConverter().Convert(importAuditPackage);
        auditPackage.ReportedAgencies = new ReportedAgencyConverter().Convert(importAuditPackage);
        auditPackage.ReportRevisions = new ReportRevisionConverter().Convert(importAuditPackage);
        
        if (importAuditPackage.Audit != null)
        {
            if (!string.IsNullOrEmpty(importAuditPackage.Audit.Audityear))
            {
                auditPackage.AuditYear = short.Parse(importAuditPackage.Audit.Audityear);
            }

            if (!string.IsNullOrEmpty(importAuditPackage.Audit.Audittype))
            {
                auditPackage.Audittype = importAuditPackage.Audit.Audittype;    
            }

            if (!string.IsNullOrEmpty(importAuditPackage.Audit.COGOver))
            {
                auditPackage.COGAgency = importAuditPackage.Audit.COGAgency;    
            }

            if (!string.IsNullOrEmpty(importAuditPackage.Audit.COGAgency))
            {
                auditPackage.COG= importAuditPackage.Audit.COGOver;    
            }

            auditPackage.DollarThreshold = importAuditPackage.Audit.DollarThreshold.ToMoney();
            auditPackage.EntityType = importAuditPackage.Audit.EntityType;
            auditPackage.FACDBKey = importAuditPackage.DbKey;
            auditPackage.Numbermonths = importAuditPackage.Audit.Numbermonths.ToDefaultShort();
            auditPackage.Periodcovered = importAuditPackage.Audit.Periodcovered;
            auditPackage.SuppressionCode = importAuditPackage.Audit.SuppressionCode;
            auditPackage.TotalFederalExpendature = importAuditPackage.Audit.TotalFederalExpendature.ToMoney();
            auditPackage.TypeOfEntity = importAuditPackage.Audit.TypeOfEntity;

        }

        if (importAuditPackage.History != null)
        {
            auditPackage.FACReportId = importAuditPackage.History.Reportid.ToDefaultInt();
            auditPackage.Version = importAuditPackage.History.Version.ToDefaultShort();
        }
        
        return auditPackage;
    }
}