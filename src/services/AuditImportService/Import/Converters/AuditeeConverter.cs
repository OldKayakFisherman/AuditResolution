using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;

namespace AuditImportService.Import.Converters;

public class AuditeeConverter
{
    public Auditee? Convert(ImportAuditPackage auditPackage)
    {
        Auditee? auditee = null;

        if (auditPackage.Audit != null)
        {
            auditee = new Auditee();
            
            auditee.City = auditPackage.Audit.City;
            auditee.AuditeeEmail = auditPackage.Audit.AuditeeEmail;
            auditee.AuditeeFax = auditPackage.Audit.AuditeeFax;
            auditee.AuditeePhone = auditPackage.Audit.AuditeePhone;
            auditee.Contact = auditPackage.Audit.AuditeeContact;
            auditee.Name = auditPackage.Audit.AuditeeName!;
            auditee.State = auditPackage.Audit.State;
            auditee.Street1 = auditPackage.Audit.Street1;
            auditee.Title = auditPackage.Audit.AuditeeTitle;
            auditee.Zipcode = auditPackage.Audit.Zipcode;
            auditee.EIN = auditPackage.Audit.EIN;
            auditee.UEI = auditPackage.Audit.UEI;
            auditee.DUNS = auditPackage.Audit.DUNS;
        }

        return auditee;
    }
}