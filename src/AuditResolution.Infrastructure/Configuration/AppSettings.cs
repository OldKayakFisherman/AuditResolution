using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditResolution.Infrastructure.Configuration
{
    public class AppSettings
    {
        public DateTime? ImportStartDate { get; set; }
        public string BaseDataFormUrl { get; set; }
        public string BaseDataDBKeyUrl { get; set; }
        public string BaseDataImageUrl { get; set; }
    }
}
