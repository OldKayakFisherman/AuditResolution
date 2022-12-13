using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuditImportService.Migrations
{
    /// <inheritdoc />
    public partial class AddDbKeyImportLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBKEY_IMPORT_LOG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DBKEY = table.Column<int>(type: "INTEGER", nullable: false),
                    AUDITYEAR = table.Column<short>(type: "INTEGER", nullable: false),
                    DATEADDED = table.Column<DateTime>(name: "DATE_ADDED", type: "TEXT", nullable: false),
                    DATEIMPORTED = table.Column<DateTime>(name: "DATE_IMPORTED", type: "TEXT", nullable: true),
                    PDFIMPORTED = table.Column<bool>(name: "PDF_IMPORTED", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBKEY_IMPORT_LOG", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBKEY_IMPORT_LOG");
        }
    }
}
