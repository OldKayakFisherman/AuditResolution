using Newtonsoft.Json;

namespace AuditImportService.Import.Models
{
    public class ImportDbKey
    {
        [JsonProperty("Item1")]
        public int DbKey { get; set; }
        [JsonProperty("Item2")]
        public short AuditYear { get; set; }
    }
}
