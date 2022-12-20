using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;

namespace AuditImportService.Import.Converters;

public class FindingConverter
{
    public IList<Finding>? Convert(IList<ImportAuditFinding>? importAuditFindings, int awardId)
    {
        IList<Finding>? findings = null;

        if (importAuditFindings != null && awardId > 0)
        {
            IList<ImportAuditFinding>? filteredImportFindings =
                importAuditFindings
                    .Where(x => x.ElecAuditsId == awardId.ToString()).ToList();

            if (filteredImportFindings.Count > 0)
            {
                findings = new List<Finding>();

                foreach (var importAuditFinding in filteredImportFindings)
                {
                    Finding finding = new Finding();

                    finding.SignificantDeficiency = importAuditFinding.SignificantDeficiency.ConvertFromYNString();
                    finding.OtherFindings = importAuditFinding.OtherFindings.ConvertFromYNString();
                    finding.RepeatFinding = importAuditFinding.RepeatFinding.ConvertFromYNString();
                    finding.QuestionedCosts = importAuditFinding.QCosts.ConvertFromYNString();
                    finding.MaterialWeakness = importAuditFinding.MaterialWeakness.ConvertFromYNString();
                    finding.ModifiedOpinion = importAuditFinding.ModifiedOpinion.ConvertFromYNString();
                    finding.TypeRequirement = importAuditFinding.TypeRequirement;
                    finding.FindingRefNums = importAuditFinding.FindingRefNums;
                    finding.OtherNonCompliance = importAuditFinding.OtherFindings.ConvertFromYNString();
                    finding.PriorFindingRefNums = importAuditFinding.PriorFindingRefNums;
                    
                    findings.Add(finding);

                }
                
                
            }
        }

        return findings;
    }
}