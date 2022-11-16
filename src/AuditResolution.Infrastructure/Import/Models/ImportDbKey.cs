using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditResolution.Infrastructure.Import.Models
{
    public class ImportDbKey
    {
        [JsonProperty("Item1")]
        public int DbKey { get; set; }
        [JsonProperty("Item2")]
        public short AuditYear { get; set; }
    }
}
