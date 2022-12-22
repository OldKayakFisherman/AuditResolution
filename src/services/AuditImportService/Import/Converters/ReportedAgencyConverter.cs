using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;

namespace AuditImportService.Import.Converters;

public class ReportedAgencyConverter
{
    public IList<ReportedAgency>? Convert(ImportAuditPackage importAuditPackage)
    {
        IList<ReportedAgency>? reportedAgencies = null;

        if (importAuditPackage.ReportedAgencies != null && importAuditPackage.ReportedAgencies.Any())
        {
            reportedAgencies = new List<ReportedAgency>();

            foreach (var importReportedAgency in importAuditPackage.ReportedAgencies)
            {
                ReportedAgency agency = new ReportedAgency();

                agency.Agencycfda = importReportedAgency.Agencycfda;
                agency.Currentfinding = importReportedAgency.Currentfinding;
                agency.Final = importReportedAgency.Final;
                agency.PriorFinding = importReportedAgency.PriorFinding;
                agency.PyAgency = importReportedAgency.PyAgency;
                
                reportedAgencies.Add(agency);
            }
            
        }

        return reportedAgencies;
    }
}