using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AuditImportService.Data.Entities;


    [Table("TRAFFIC_LOGS")]
    public class TrafficLog
    {
        [Key, Column("ID")]
        public int Id { get; set; }

        [Column("LOCAL_PORT")]
        public int? LocalPort { get; set; }

        [Column("REMOTE_PORT")]
        public int? RemotePort { get; set; }

        [Column("LOCAL_IP")]
        public string? LocalIP { get; set; }

        [Column("REMOTE_IP")]
        public string? RemoteIP { get; set; }

        [Column("REQUEST_COOKIES")]
        public string? RequestCookies { get; set; }

        [Column("REQUEST_HEADERS")]
        public string? RequestHeaders { get; set; }

        [Column("HOST")]
        public string? Host { get; set; }

        [Column("REQUEST_METHOD")]
        public string? RequestMethod { get; set; }

        [Column("REQUEST_PATH")]
        public string? RequestPath { get; set; }

        [Column("REQUEST_PROTOCOL")]
        public string? RequestProtocol { get; set; }

        [Column("REQUEST_QUERY")]
        public string? RequestQuery { get; set; }

        [Column("REQUEST_SCHEME")]
        public string? RequestScheme { get; set; }

        [Column("REQUEST_LEGTH")]
        public long? RequestLength { get; set; }

        [Column("REQUEST_CONTENT_TYPE")]
        public string? RequestContentType { get; set; }

        [Column("REQUEST_QUERY_STRING")]
        public string? RequestQueryString { get; set; }

        [Column("TRAFFIC_DATE")]
        public DateTime TrafficDate { get; set; } = DateTime.Now;
        
    }   
