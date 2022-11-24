using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuditImportService.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AUDITEES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EIN = table.Column<string>(type: "TEXT", nullable: true),
                    NAME = table.Column<string>(type: "TEXT", nullable: false),
                    STREET1 = table.Column<string>(type: "TEXT", nullable: true),
                    CITY = table.Column<string>(type: "TEXT", nullable: true),
                    STATE = table.Column<string>(type: "TEXT", nullable: true),
                    ZIPCODE = table.Column<string>(type: "TEXT", nullable: true),
                    CONTACT = table.Column<string>(type: "TEXT", nullable: true),
                    TITLE = table.Column<string>(type: "TEXT", nullable: true),
                    PHONE = table.Column<string>(type: "TEXT", nullable: true),
                    FAX = table.Column<string>(type: "TEXT", nullable: true),
                    EMAIL = table.Column<string>(type: "TEXT", nullable: true),
                    UEI = table.Column<string>(type: "TEXT", nullable: true),
                    DUNS = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDITEES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CPAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FIRMNAME = table.Column<string>(type: "TEXT", nullable: true),
                    STREET1 = table.Column<string>(type: "TEXT", nullable: true),
                    CITY = table.Column<string>(type: "TEXT", nullable: true),
                    STATE = table.Column<string>(type: "TEXT", nullable: true),
                    ZIPCODE = table.Column<string>(type: "TEXT", nullable: true),
                    CONTACT = table.Column<string>(type: "TEXT", nullable: true),
                    TITLE = table.Column<string>(type: "TEXT", nullable: true),
                    PHONE = table.Column<string>(type: "TEXT", nullable: true),
                    FAX = table.Column<string>(type: "TEXT", nullable: true),
                    EMAIL = table.Column<string>(type: "TEXT", nullable: true),
                    EIN = table.Column<string>(type: "TEXT", nullable: true),
                    FOREIGN = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FEDERAL_AGENCIES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CFDAPREFIX = table.Column<string>(type: "TEXT", nullable: true),
                    NAME = table.Column<string>(type: "TEXT", nullable: true),
                    STARTEXT = table.Column<string>(type: "TEXT", nullable: true),
                    ENDEXT = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FEDERAL_AGENCIES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FIREWALL_DAYS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FACFIREWALLDATE = table.Column<DateTime>(name: "FAC_FIREWALL_DATE", type: "TEXT", nullable: false),
                    SYSTEMIMPORTDATE = table.Column<DateTime>(name: "SYSTEM_IMPORT_DATE", type: "TEXT", nullable: false),
                    RECORDSIMPORTED = table.Column<short>(name: "RECORDS_IMPORTED", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIREWALL_DAYS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AUDIT_PACKAGES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AUDITYEAR = table.Column<short>(name: "AUDIT_YEAR", type: "INTEGER", nullable: false),
                    FACDBKEY = table.Column<int>(name: "FAC_DBKEY", type: "INTEGER", nullable: false),
                    FACREPORTID = table.Column<int>(name: "FAC_REPORTID", type: "INTEGER", nullable: false),
                    FACVERSION = table.Column<short>(name: "FAC_VERSION", type: "INTEGER", nullable: false),
                    AUDITTYPE = table.Column<string>(type: "TEXT", nullable: true),
                    PERIODCOVERED = table.Column<string>(type: "TEXT", nullable: true),
                    NUMBERMONTHS = table.Column<short>(type: "INTEGER", nullable: true),
                    CPADATESIGNED = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AUDITEECERTIFYNAME = table.Column<string>(type: "TEXT", nullable: true),
                    AUDITEECERTIFYTITLE = table.Column<string>(type: "TEXT", nullable: true),
                    COG = table.Column<string>(type: "TEXT", nullable: true),
                    COGAGENCY = table.Column<string>(name: "COG_AGENCY", type: "TEXT", nullable: true),
                    DOLLARTHRESHOLD = table.Column<long>(type: "INTEGER", nullable: false),
                    TOTFEDEXPEND = table.Column<long>(type: "INTEGER", nullable: false),
                    TYPEOFENTITY = table.Column<string>(type: "TEXT", nullable: true),
                    SUPPRESSIONCODE = table.Column<string>(name: "SUPPRESSION_CODE", type: "TEXT", nullable: true),
                    ENTITYTYPE = table.Column<string>(name: "ENTITY_TYPE", type: "TEXT", nullable: true),
                    AuditeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    CPAId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDIT_PACKAGES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AUDIT_PACKAGES_AUDITEES_AuditeeId",
                        column: x => x.AuditeeId,
                        principalTable: "AUDITEES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AUDIT_PACKAGES_CPAS_CPAId",
                        column: x => x.CPAId,
                        principalTable: "CPAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ADDITIONAL_DUNS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SEQNUM = table.Column<short>(type: "INTEGER", nullable: false),
                    DUNS = table.Column<string>(type: "TEXT", nullable: true),
                    MAINDUNS = table.Column<string>(name: "MAIN_DUNS", type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDITIONAL_DUNS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ADDITIONAL_DUNS_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ADDITIONAL_EINS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EIN = table.Column<string>(type: "TEXT", nullable: false),
                    SEQNUM = table.Column<short>(type: "INTEGER", nullable: false),
                    MAINEIN = table.Column<string>(name: "MAIN_EIN", type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDITIONAL_EINS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ADDITIONAL_EINS_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ADDITIONAL_UEIS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UEI = table.Column<string>(type: "TEXT", nullable: true),
                    SEQNUM = table.Column<short>(type: "INTEGER", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDITIONAL_UEIS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ADDITIONAL_UEIS_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AUDIT_INDICATORS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TYPEREPORTFS = table.Column<string>(name: "TYPEREPORT_FS", type: "TEXT", nullable: true),
                    MATERIALNONCOMPLIANCE = table.Column<bool>(type: "INTEGER", nullable: false),
                    GOINGCONCERN = table.Column<bool>(type: "INTEGER", nullable: false),
                    TYPEREPORTMP = table.Column<string>(name: "TYPEREPORT_MP", type: "TEXT", nullable: true),
                    LOWRISK = table.Column<bool>(type: "INTEGER", nullable: false),
                    QCOSTS = table.Column<bool>(type: "INTEGER", nullable: false),
                    PYSCHEDULE = table.Column<bool>(type: "INTEGER", nullable: false),
                    DUPREPORTS = table.Column<bool>(name: "DUP_REPORTS", type: "INTEGER", nullable: false),
                    SIGNIFICANTDEFICIENCY = table.Column<bool>(type: "INTEGER", nullable: false),
                    SDMATERIALWEAKNESS = table.Column<bool>(name: "SD_MATERIALWEAKNESS", type: "INTEGER", nullable: false),
                    SIGNIFICANTDEFICIENCYMP = table.Column<bool>(name: "SIGNIFICANTDEFICIENCY_MP", type: "INTEGER", nullable: false),
                    SDMATERIALWEAKNESSMP = table.Column<bool>(name: "SD_MATERIALWEAKNESS_MP", type: "INTEGER", nullable: false),
                    SPFRAMEWORK = table.Column<string>(name: "SP_FRAMEWORK", type: "TEXT", nullable: true),
                    SPFRAMEWORKREQUIRED = table.Column<bool>(name: "SP_FRAMEWORK_REQUIRED", type: "INTEGER", nullable: false),
                    TYPEREPORTSPFRAMEWORK = table.Column<string>(name: "TYPEREPORT_SP_FRAMEWORK", type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDIT_INDICATORS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AUDIT_INDICATORS_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AUDIT_TIMEFRAMES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AUDITEESUBMITDATE = table.Column<DateTime>(name: "AUDITEE_SUBMIT_DATE", type: "TEXT", nullable: false),
                    AUDITORSUBMITDATE = table.Column<DateTime>(name: "AUDITOR_SUBMIT_DATE", type: "TEXT", nullable: false),
                    FACFIREWALLDATE = table.Column<DateTime>(name: "FAC_FIREWALL_DATE", type: "TEXT", nullable: false),
                    SYSTEMIMPORTDATE = table.Column<DateTime>(name: "SYSTEM_IMPORT_DATE", type: "TEXT", nullable: false),
                    FYENDDATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FYSTARTDATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDIT_TIMEFRAMES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AUDIT_TIMEFRAMES_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AWARDS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CFDASEQNUM = table.Column<string>(type: "TEXT", nullable: true),
                    FEDERALPROGRAMNAME = table.Column<string>(type: "TEXT", nullable: true),
                    AMOUNT = table.Column<long>(type: "INTEGER", nullable: false),
                    MAJORPROGRAM = table.Column<bool>(type: "INTEGER", nullable: false),
                    TYPEREQUIREMENT = table.Column<string>(type: "TEXT", nullable: true),
                    FINDINGREFNUMS = table.Column<string>(type: "TEXT", nullable: true),
                    RD = table.Column<bool>(type: "INTEGER", nullable: false),
                    DIRECT = table.Column<bool>(type: "INTEGER", nullable: false),
                    CFDAPREFIX = table.Column<string>(name: "CFDA_PREFIX", type: "TEXT", nullable: true),
                    CFDAEXT = table.Column<string>(name: "CFDA_EXT", type: "TEXT", nullable: true),
                    TYPEREPORTMP = table.Column<string>(name: "TYPEREPORT_MP", type: "TEXT", nullable: true),
                    ARRA = table.Column<bool>(type: "INTEGER", nullable: false),
                    LOANS = table.Column<bool>(type: "INTEGER", nullable: false),
                    LOANBALANCE = table.Column<long>(type: "INTEGER", nullable: true),
                    PASSTHROUGHAMOUNT = table.Column<long>(type: "INTEGER", nullable: true),
                    AWARDIDENTIFICATION = table.Column<string>(type: "TEXT", nullable: true),
                    CLUSTERNAME = table.Column<string>(type: "TEXT", nullable: true),
                    PASSTHROUGHAWARD = table.Column<string>(type: "TEXT", nullable: true),
                    STATECLUSTERNAME = table.Column<string>(type: "TEXT", nullable: true),
                    PROGRAMTOTAL = table.Column<long>(type: "INTEGER", nullable: true),
                    CLUSTERTOTAL = table.Column<long>(type: "INTEGER", nullable: true),
                    OTHERCLUSTERNAME = table.Column<string>(type: "TEXT", nullable: true),
                    CFDAKEY = table.Column<string>(name: "CFDA_KEY", type: "TEXT", nullable: true),
                    DEFAULTPROGRAMNAME = table.Column<string>(name: "DEFAULT_PROGRAM_NAME", type: "TEXT", nullable: true),
                    DEFAULTCLUSTERNAME = table.Column<string>(name: "DEFAULT_CLUSTER_NAME", type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AWARDS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AWARDS_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CAP_TEXT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SEQNUMBER = table.Column<short>(name: "SEQ_NUMBER", type: "INTEGER", nullable: false),
                    FINDINGREFNUMS = table.Column<string>(type: "TEXT", nullable: true),
                    TEXT = table.Column<string>(type: "TEXT", nullable: true),
                    CHARTSTABLES = table.Column<string>(type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAP_TEXT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CAP_TEXT_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FINDING_TEXT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SEQNUMBER = table.Column<short>(name: "SEQ_NUMBER", type: "INTEGER", nullable: false),
                    FINDINGREFNUMS = table.Column<string>(type: "TEXT", nullable: true),
                    TEXT = table.Column<string>(type: "TEXT", nullable: true),
                    CHARTSTABLES = table.Column<string>(type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FINDING_TEXT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FINDING_TEXT_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PASSTHROUGHS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PASSTHROUGHNAME = table.Column<string>(type: "TEXT", nullable: true),
                    PASSTHROUGHID = table.Column<string>(type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PASSTHROUGHS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PASSTHROUGHS_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReportedAgencies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AGENCYCFDA = table.Column<string>(type: "TEXT", nullable: true),
                    PYAGENCY = table.Column<string>(type: "TEXT", nullable: true),
                    PRIORFINDING = table.Column<string>(type: "TEXT", nullable: true),
                    CURRENTFINDING = table.Column<string>(type: "TEXT", nullable: true),
                    FINAL = table.Column<string>(type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedAgencies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReportedAgencies_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReportRevisions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GENINFO = table.Column<string>(type: "TEXT", nullable: true),
                    GENINFOEXPLAIN = table.Column<string>(name: "GENINFO_EXPLAIN", type: "TEXT", nullable: true),
                    FEDERALAWARDS = table.Column<string>(type: "TEXT", nullable: true),
                    FEDERALAWARDSEXPLAIN = table.Column<string>(name: "FEDERALAWARDS_EXPLAIN", type: "TEXT", nullable: true),
                    NOTESTOSEFA = table.Column<string>(type: "TEXT", nullable: true),
                    NOTESTOSEFAEXPLAIN = table.Column<string>(name: "NOTESTOSEFA_EXPLAIN", type: "TEXT", nullable: true),
                    AUDITINFO = table.Column<string>(type: "TEXT", nullable: true),
                    AUDITINFOEXPLAIN = table.Column<string>(name: "AUDITINFO_EXPLAIN", type: "TEXT", nullable: true),
                    FINDINGS = table.Column<string>(type: "TEXT", nullable: true),
                    FINDINGSEXPLAIN = table.Column<string>(name: "FINDINGS_EXPLAIN", type: "TEXT", nullable: true),
                    FINDINGSTEXT = table.Column<string>(type: "TEXT", nullable: true),
                    FINDINGSTEXTEXPLAIN = table.Column<string>(name: "FINDINGSTEXT_EXPLAIN", type: "TEXT", nullable: true),
                    CAP = table.Column<string>(type: "TEXT", nullable: true),
                    CAPEXPLAIN = table.Column<string>(name: "CAP_EXPLAIN", type: "TEXT", nullable: true),
                    OTHER = table.Column<string>(type: "TEXT", nullable: true),
                    OTHEREXPLAIN = table.Column<string>(name: "OTHER_EXPLAIN", type: "TEXT", nullable: true),
                    AuditPackageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportRevisions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReportRevisions_AUDIT_PACKAGES_AuditPackageId",
                        column: x => x.AuditPackageId,
                        principalTable: "AUDIT_PACKAGES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FINDINGS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QCOSTS = table.Column<bool>(type: "INTEGER", nullable: false),
                    OTHERFINDINGS = table.Column<bool>(type: "INTEGER", nullable: false),
                    SIGNIFICANTDEFICIENCY = table.Column<string>(type: "TEXT", nullable: true),
                    MATERIALWEAKNESS = table.Column<bool>(type: "INTEGER", nullable: false),
                    OTHERNONCOMPLIANCE = table.Column<bool>(type: "INTEGER", nullable: false),
                    TYPEREQUIREMENT = table.Column<string>(type: "TEXT", nullable: true),
                    FINDINGREFNUMS = table.Column<string>(type: "TEXT", nullable: true),
                    MODIFIEDOPINION = table.Column<bool>(type: "INTEGER", nullable: false),
                    REPEATFINDING = table.Column<bool>(type: "INTEGER", nullable: false),
                    PRIORFINDINGREFNUMS = table.Column<string>(type: "TEXT", nullable: true),
                    AwardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FINDINGS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FINDINGS_AWARDS_AwardId",
                        column: x => x.AwardId,
                        principalTable: "AWARDS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADDITIONAL_DUNS_AuditPackageId",
                table: "ADDITIONAL_DUNS",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ADDITIONAL_EINS_AuditPackageId",
                table: "ADDITIONAL_EINS",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ADDITIONAL_UEIS_AuditPackageId",
                table: "ADDITIONAL_UEIS",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_AUDIT_INDICATORS_AuditPackageId",
                table: "AUDIT_INDICATORS",
                column: "AuditPackageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AUDIT_PACKAGES_AuditeeId",
                table: "AUDIT_PACKAGES",
                column: "AuditeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AUDIT_PACKAGES_CPAId",
                table: "AUDIT_PACKAGES",
                column: "CPAId");

            migrationBuilder.CreateIndex(
                name: "IX_AUDIT_TIMEFRAMES_AuditPackageId",
                table: "AUDIT_TIMEFRAMES",
                column: "AuditPackageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AWARDS_AuditPackageId",
                table: "AWARDS",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CAP_TEXT_AuditPackageId",
                table: "CAP_TEXT",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_FINDING_TEXT_AuditPackageId",
                table: "FINDING_TEXT",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_FINDINGS_AwardId",
                table: "FINDINGS",
                column: "AwardId");

            migrationBuilder.CreateIndex(
                name: "IX_PASSTHROUGHS_AuditPackageId",
                table: "PASSTHROUGHS",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedAgencies_AuditPackageId",
                table: "ReportedAgencies",
                column: "AuditPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportRevisions_AuditPackageId",
                table: "ReportRevisions",
                column: "AuditPackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADDITIONAL_DUNS");

            migrationBuilder.DropTable(
                name: "ADDITIONAL_EINS");

            migrationBuilder.DropTable(
                name: "ADDITIONAL_UEIS");

            migrationBuilder.DropTable(
                name: "AUDIT_INDICATORS");

            migrationBuilder.DropTable(
                name: "AUDIT_TIMEFRAMES");

            migrationBuilder.DropTable(
                name: "CAP_TEXT");

            migrationBuilder.DropTable(
                name: "FEDERAL_AGENCIES");

            migrationBuilder.DropTable(
                name: "FINDING_TEXT");

            migrationBuilder.DropTable(
                name: "FINDINGS");

            migrationBuilder.DropTable(
                name: "FIREWALL_DAYS");

            migrationBuilder.DropTable(
                name: "PASSTHROUGHS");

            migrationBuilder.DropTable(
                name: "ReportedAgencies");

            migrationBuilder.DropTable(
                name: "ReportRevisions");

            migrationBuilder.DropTable(
                name: "AWARDS");

            migrationBuilder.DropTable(
                name: "AUDIT_PACKAGES");

            migrationBuilder.DropTable(
                name: "AUDITEES");

            migrationBuilder.DropTable(
                name: "CPAS");
        }
    }
}
