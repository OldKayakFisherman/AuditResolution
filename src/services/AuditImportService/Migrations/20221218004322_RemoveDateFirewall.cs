using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuditImportService.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDateFirewall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FAC_FIREWALL_DATE",
                table: "AUDIT_TIMEFRAMES");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FAC_FIREWALL_DATE",
                table: "AUDIT_TIMEFRAMES",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
