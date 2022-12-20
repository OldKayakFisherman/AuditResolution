using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;



namespace AuditImportService.Import.Converters;

public class AwardConverter
{
    public IList<Award>? Convert(ImportAuditPackage auditPackage)
    {
        IList<Award>? awards = new List<Award>();

        if (auditPackage.Awards != null)
        {
            foreach (var importAward in auditPackage.Awards)
            {
                Award award = new Award();

                award.AwardIdentification = importAward.AwardIdentification;
                award.Amount = importAward.Amount.ToMoney();
                award.TypeReportMajorProgram = importAward.TypeReportMP;
                award.PassthroughAward = importAward.PassthroughAward;
                award.Direct = importAward.Direct.ConvertFromYNString();
                award.Findings =
                    new FindingConverter().Convert(auditPackage.Findings, importAward.ElecauditsId.ToDefaultInt());
                
                awards.Add(award);
            }
        }

        return awards;
    }
}