using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuditImportService.Migrations
{
    /// <inheritdoc />
    public partial class FieldRefactorFromConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPADATESIGNED",
                table: "AUDIT_PACKAGES");

            migrationBuilder.AlterColumn<bool>(
                name: "SIGNIFICANTDEFICIENCY",
                table: "FINDINGS",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PROGRAMTOTAL",
                table: "AWARDS",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PASSTHROUGHAMOUNT",
                table: "AWARDS",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LOANBALANCE",
                table: "AWARDS",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CLUSTERTOTAL",
                table: "AWARDS",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AMOUNT",
                table: "AWARDS",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "CPA_DATE_SIGNED",
                table: "AUDIT_TIMEFRAMES",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TOTFEDEXPEND",
                table: "AUDIT_PACKAGES",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<decimal>(
                name: "DOLLARTHRESHOLD",
                table: "AUDIT_PACKAGES",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPA_DATE_SIGNED",
                table: "AUDIT_TIMEFRAMES");

            migrationBuilder.AlterColumn<string>(
                name: "SIGNIFICANTDEFICIENCY",
                table: "FINDINGS",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<long>(
                name: "PROGRAMTOTAL",
                table: "AWARDS",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PASSTHROUGHAMOUNT",
                table: "AWARDS",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "LOANBALANCE",
                table: "AWARDS",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CLUSTERTOTAL",
                table: "AWARDS",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "AMOUNT",
                table: "AWARDS",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "TOTFEDEXPEND",
                table: "AUDIT_PACKAGES",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<long>(
                name: "DOLLARTHRESHOLD",
                table: "AUDIT_PACKAGES",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CPADATESIGNED",
                table: "AUDIT_PACKAGES",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
