namespace AuditImportService.Import.Parsers.Results;

public class DBKeyParseRecord
{
    public DateTime ParsedFirewallDate { get; set; }
    public IList<Tuple<int, short>> ParsedDBKeyAuditYears { get; set; }
}

public class DBKeyParseResult
{
    public DateTime ParseDate { get; set; }
    public IList<DBKeyParseRecord> ParseRecords { get; set; } = new List<DBKeyParseRecord>();
}