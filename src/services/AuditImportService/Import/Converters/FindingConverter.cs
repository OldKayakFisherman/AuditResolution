using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;

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
                    
                }
                
                
            }
        }

        return findings;
    }
}