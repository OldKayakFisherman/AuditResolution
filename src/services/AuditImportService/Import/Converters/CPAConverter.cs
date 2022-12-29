using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;

namespace AuditImportService.Import.Converters;

public class CPAConverter
{
    public CPA? Convert(ImportAuditPackage importAuditPackage)
    {
        CPA? cpa = null;

        if (importAuditPackage.Audit != null)
        {
            cpa = new CPA();
            
            cpa.City = importAuditPackage.Audit.CPACity;
            cpa.Contact = importAuditPackage.Audit.CPAContact;
            cpa.EIN = importAuditPackage.Audit.AuditorEIN;
            cpa.Email = importAuditPackage.Audit.CPAEmail;
            cpa.Fax = importAuditPackage.Audit.CPAFax;
            cpa.Firmname = importAuditPackage.Audit.CPAFirmname;
            cpa.Foreign = importAuditPackage.Audit.CPAForeign.ConvertFromYNString();
            cpa.Phone = importAuditPackage.Audit.CPAPhone;
            cpa.State = importAuditPackage.Audit.CPAState;
            cpa.Street1 = importAuditPackage.Audit.CPAStreet1;
            cpa.Title = importAuditPackage.Audit.CPATitle;
            cpa.Zipcode = importAuditPackage.Audit.CPAZipcode;
        }

        return cpa;
    }
}