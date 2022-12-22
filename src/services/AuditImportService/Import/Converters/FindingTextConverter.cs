using AuditImportService.Data.Entities;
using AuditImportService.Import.Models;
using AuditResolution.Common.Extensions;

namespace AuditImportService.Import.Converters;

public class FindingTextConverter
{
    public IList<FindingText>? Convert(ImportAuditPackage importAuditPackage)
    {
        IList<FindingText>? findingTexts = null;

        if (importAuditPackage.FindingsTexts != null && importAuditPackage.FindingsTexts.Any())
        {
            foreach (var importFindingText in importAuditPackage.FindingsTexts)
            {
                FindingText findingText = new FindingText();

                findingText.ChartsTables = importFindingText.Chartstables;
                findingText.FindingRefNums = importFindingText.Findingrefnums;
                findingText.SeqNumber = importFindingText.SeqNumber.ToDefaultShort();
                findingText.Text = importFindingText.Text;
            }
        }
        
        return findingTexts;
    }
}