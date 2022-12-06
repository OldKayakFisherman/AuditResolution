using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuditImportService.Migrations
{
    /// <inheritdoc />
    public partial class TrafficAndErrors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SYSTEM_ERRORS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MESSAGE = table.Column<string>(type: "TEXT", nullable: false),
                    EXCEPTIONTYPE = table.Column<string>(name: "EXCEPTION_TYPE", type: "TEXT", nullable: true),
                    STACKTRACE = table.Column<string>(name: "STACK_TRACE", type: "TEXT", nullable: true),
                    EVENTDATE = table.Column<DateTime>(name: "EVENT_DATE", type: "TEXT", nullable: false),
                    REQUESTPATH = table.Column<string>(name: "REQUEST_PATH", type: "TEXT", nullable: true),
                    REQUESTHEADERS = table.Column<string>(name: "REQUEST_HEADERS", type: "TEXT", nullable: true),
                    REMOTEADDRESS = table.Column<string>(name: "REMOTE_ADDRESS", type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSTEM_ERRORS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TRAFFIC_LOGS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LOCALPORT = table.Column<int>(name: "LOCAL_PORT", type: "INTEGER", nullable: true),
                    REMOTEPORT = table.Column<int>(name: "REMOTE_PORT", type: "INTEGER", nullable: true),
                    LOCALIP = table.Column<string>(name: "LOCAL_IP", type: "TEXT", nullable: true),
                    REMOTEIP = table.Column<string>(name: "REMOTE_IP", type: "TEXT", nullable: true),
                    REQUESTCOOKIES = table.Column<string>(name: "REQUEST_COOKIES", type: "TEXT", nullable: true),
                    REQUESTHEADERS = table.Column<string>(name: "REQUEST_HEADERS", type: "TEXT", nullable: true),
                    HOST = table.Column<string>(type: "TEXT", nullable: true),
                    REQUESTMETHOD = table.Column<string>(name: "REQUEST_METHOD", type: "TEXT", nullable: true),
                    REQUESTPATH = table.Column<string>(name: "REQUEST_PATH", type: "TEXT", nullable: true),
                    REQUESTPROTOCOL = table.Column<string>(name: "REQUEST_PROTOCOL", type: "TEXT", nullable: true),
                    REQUESTQUERY = table.Column<string>(name: "REQUEST_QUERY", type: "TEXT", nullable: true),
                    REQUESTSCHEME = table.Column<string>(name: "REQUEST_SCHEME", type: "TEXT", nullable: true),
                    REQUESTLEGTH = table.Column<long>(name: "REQUEST_LEGTH", type: "INTEGER", nullable: true),
                    REQUESTCONTENTTYPE = table.Column<string>(name: "REQUEST_CONTENT_TYPE", type: "TEXT", nullable: true),
                    REQUESTQUERYSTRING = table.Column<string>(name: "REQUEST_QUERY_STRING", type: "TEXT", nullable: true),
                    TRAFFICDATE = table.Column<DateTime>(name: "TRAFFIC_DATE", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAFFIC_LOGS", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SYSTEM_ERRORS");

            migrationBuilder.DropTable(
                name: "TRAFFIC_LOGS");
        }
    }
}
