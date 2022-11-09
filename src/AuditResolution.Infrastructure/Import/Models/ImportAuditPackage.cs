using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AuditResolution.Infrastructure.Import.Models
{
    public class ImportAuditPackage
    {
        [JsonProperty("mainEin")]
        public string MainEin { get; set; }

        [JsonProperty("header")]
        public ImportAudit Audit { get; set; }
    }
}
