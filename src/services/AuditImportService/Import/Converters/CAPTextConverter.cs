using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;

namespace AuditImportService.Import.Converters;

public class CAPTextConverter
{
    public IList<CAPText>? Convert(ImportAuditPackage importAuditPackage)
    {
        IList<CAPText>? capTexts = null;

        if (importAuditPackage.CAPTexts != null &&
            importAuditPackage.CAPTexts.Count > 0)
        {
            capTexts = new List<CAPText>();

            foreach (var importCapText in importAuditPackage.CAPTexts)
            {
                var captext = new CAPText();
                
                captext.Chartstables = importCapText.Chartstables;
                captext.Findingrefnums = importCapText.Findingrefnums;
                captext.SeqNumber = importCapText.SeqNumber.ToDefaultShort();
                captext.Text = importCapText.Text;
                
                capTexts.Add(captext);
            }
            
        }

        return capTexts;
    }
}