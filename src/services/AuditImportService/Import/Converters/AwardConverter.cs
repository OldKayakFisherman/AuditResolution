using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;



namespace AuditImportService.Import.Converters;

public class AwardConverter
{
    public IList<Award>? Convert(ImportAuditPackage auditPackage)
    {
        IList<Award>? awards = null;

        if (auditPackage.Awards != null)
        {

            awards = new List<Award>();
            
            foreach (var importAward in auditPackage.Awards)
            {
                Award award = new Award();

                award.Amount = importAward.Amount.ToMoney();
                award.ARRA = importAward.ARRA.ConvertFromYNString();
                award.AwardIdentification = importAward.AwardIdentification;
                award.CFDAExt = importAward.CFDAExt;
                award.CFDAKey = importAward.CFDAKey;
                award.CFDAPrefix = importAward.CFDAPrefix;
                award.CFDASequenceNumber = importAward.CFDASequenceNumber;
                award.ClusterName = importAward.ClusterName;
                award.ClusterTotal = importAward.ClusterTotal.ToMoney();
                award.DefaultClusterName = importAward.DefaultClusterName;
                award.DefaultProgramName = importAward.DefaultProgramName;
                award.Direct = importAward.Direct.ConvertFromYNString();
                award.FederalProgramName = importAward.FederalProgramName;
                award.FindingRefNums = importAward.FindingRefNums;
                award.Findings =
                    new FindingConverter().Convert(auditPackage.Findings, importAward.ElecauditsId.ToDefaultInt());
                award.LoanBalance = importAward.LoanBalance.ToMoney();
                award.Loans = importAward.Loans.ConvertFromYNString();
                award.MajorProgram = importAward.MajorProgram.ConvertFromYNString();
                award.OtherClusterName = importAward.OtherClusterName;
                award.PassthroughAmount = importAward.PassthroughAmount.ToMoney(); 
                award.PassthroughAward = importAward.PassthroughAward;
                award.ProgramTotal = importAward.ProgramTotal.ToMoney();
                award.ResearchAndDevelopment = importAward.RD.ConvertFromYNString();
                award.StateClustername = importAward.StateClustername;
                award.TypeReportMajorProgram = importAward.TypeReportMP;
                award.TypeRequirement = importAward.TypeRequirement;
                
                awards.Add(award);
            }
        }

        return awards;
    }
}