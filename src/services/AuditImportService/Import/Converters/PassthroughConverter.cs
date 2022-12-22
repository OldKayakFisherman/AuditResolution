using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;

namespace AuditImportService.Import.Converters;

public class PassthroughConverter
{
    public IList<Passthrough>? Convert(ImportAuditPackage importAuditPackage)
    {
        IList<Passthrough>? passthroughs = null;

        if (importAuditPackage.Passthroughs != null && importAuditPackage.Passthroughs.Any())
        {
            passthroughs = new List<Passthrough>();
            
            foreach (var importPassthrough  in importAuditPackage.Passthroughs)
            {
                Passthrough passthrough = new Passthrough();

                passthrough.PassthroughId = importPassthrough.PassthroughId;
                passthrough.PassthroughName = importPassthrough.PassthroughName;
                
                passthroughs.Add(passthrough);
            }
        }

        return passthroughs;
    }
}