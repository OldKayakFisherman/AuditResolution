using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;

namespace AuditImportService.Import.Converters;

public class ReportRevisionConverter
{
    public IList<ReportRevision>? Convert(ImportAuditPackage importAuditPackage)
    {
        IList<ReportRevision>? revisions = null;

        if (importAuditPackage.ReportRevisions != null && importAuditPackage.ReportRevisions.Any())
        {
            revisions = new List<ReportRevision>();

            foreach (var importRevision in importAuditPackage.ReportRevisions)
            {
                ReportRevision revision = new ReportRevision();

                revision.AuditInfo = importRevision.AuditInfo;
                revision.AuditInfoExplain = importRevision.AuditInfoExplain;
                revision.CAP = importRevision.CAP;
                revision.CapExplain = importRevision.CapExplain;
                revision.FederalAwards = importRevision.FederalAwards;
                revision.FederalAwardsExplain = importRevision.FederalAwardsExplain;
                revision.Findings = importRevision.Findings;
                revision.FindingsExplain = importRevision.FindingsExplain;
                revision.FindingsText = importRevision.FindingsText;
                revision.FindingsTextExplain = importRevision.FindingsTextExplain;
                revision.GenInfo = importRevision.GenInfo;
                revision.GenInfoExplain = importRevision.GenInfoExplain;
                revision.NotesToSEFA = importRevision.NotesToSEFA;
                revision.NotesToSEFAExplain = importRevision.NotesToSEFAExplain;
                revision.Other = importRevision.Other;
                revision.OtherExplain = importRevision.OtherExplain;
                
                revisions.Add(revision);
            }
        }

        return revisions;
    }
}