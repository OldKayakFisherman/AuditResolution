﻿// <auto-generated />
using System;
using AuditImportService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuditImportService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221124234313_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("AuditImportService.Data.Entities.AdditionalDUN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DUNs")
                        .HasColumnType("TEXT")
                        .HasColumnName("DUNS");

                    b.Property<string>("MainDUNs")
                        .HasColumnType("TEXT")
                        .HasColumnName("MAIN_DUNS");

                    b.Property<short>("SeqNum")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SEQNUM");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("ADDITIONAL_DUNS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AdditionalEIN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EIN")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("EIN");

                    b.Property<string>("MainEIN")
                        .HasColumnType("TEXT")
                        .HasColumnName("MAIN_EIN");

                    b.Property<short>("SeqNum")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SEQNUM");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("ADDITIONAL_EINS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AdditionalUEI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<short?>("SeqNum")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SEQNUM");

                    b.Property<string>("UEI")
                        .HasColumnType("TEXT")
                        .HasColumnName("UEI");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("ADDITIONAL_UEIS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<string>("CFDAPrefix")
                        .HasColumnType("TEXT")
                        .HasColumnName("CFDAPREFIX");

                    b.Property<string>("EndExt")
                        .HasColumnType("TEXT")
                        .HasColumnName("ENDEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("NAME");

                    b.Property<string>("StartExt")
                        .HasColumnType("TEXT")
                        .HasColumnName("STARTEXT");

                    b.HasKey("Id");

                    b.ToTable("FEDERAL_AGENCIES");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AuditIndicators", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DuplicateReports")
                        .HasColumnType("INTEGER")
                        .HasColumnName("DUP_REPORTS");

                    b.Property<bool>("GoingConcern")
                        .HasColumnType("INTEGER")
                        .HasColumnName("GOINGCONCERN");

                    b.Property<bool>("LowRisk")
                        .HasColumnType("INTEGER")
                        .HasColumnName("LOWRISK");

                    b.Property<bool>("MaterialNonCompliance")
                        .HasColumnType("INTEGER")
                        .HasColumnName("MATERIALNONCOMPLIANCE");

                    b.Property<bool>("PriorYearSchedule")
                        .HasColumnType("INTEGER")
                        .HasColumnName("PYSCHEDULE");

                    b.Property<bool>("QCosts")
                        .HasColumnType("INTEGER")
                        .HasColumnName("QCOSTS");

                    b.Property<bool>("SignificantDeficiency")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SIGNIFICANTDEFICIENCY");

                    b.Property<bool>("SignificantDeficiencyMajorProgram")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SIGNIFICANTDEFICIENCY_MP");

                    b.Property<bool>("SignificantDeficiencyMaterialWeakness")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SD_MATERIALWEAKNESS");

                    b.Property<bool>("SignificantDeficiencyMaterialWeaknessMajorProgram")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SD_MATERIALWEAKNESS_MP");

                    b.Property<string>("SpecialFramework")
                        .HasColumnType("TEXT")
                        .HasColumnName("SP_FRAMEWORK");

                    b.Property<bool>("SpecialFrameworkFrameworkRequired")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SP_FRAMEWORK_REQUIRED");

                    b.Property<string>("TypeReportFinancialStatements")
                        .HasColumnType("TEXT")
                        .HasColumnName("TYPEREPORT_FS");

                    b.Property<string>("TypeReportMajorProgram")
                        .HasColumnType("TEXT")
                        .HasColumnName("TYPEREPORT_MP");

                    b.Property<string>("TypeReportSpecialFramework")
                        .HasColumnType("TEXT")
                        .HasColumnName("TYPEREPORT_SP_FRAMEWORK");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId")
                        .IsUnique();

                    b.ToTable("AUDIT_INDICATORS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AuditPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<short>("AuditYear")
                        .HasColumnType("INTEGER")
                        .HasColumnName("AUDIT_YEAR");

                    b.Property<string>("AuditeeCertifyName")
                        .HasColumnType("TEXT")
                        .HasColumnName("AUDITEECERTIFYNAME");

                    b.Property<string>("AuditeeCertifyTitle")
                        .HasColumnType("TEXT")
                        .HasColumnName("AUDITEECERTIFYTITLE");

                    b.Property<int?>("AuditeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Audittype")
                        .HasColumnType("TEXT")
                        .HasColumnName("AUDITTYPE");

                    b.Property<string>("COG")
                        .HasColumnType("TEXT")
                        .HasColumnName("COG");

                    b.Property<string>("COGAgency")
                        .HasColumnType("TEXT")
                        .HasColumnName("COG_AGENCY");

                    b.Property<DateTime>("CPADateSigned")
                        .HasColumnType("TEXT")
                        .HasColumnName("CPADATESIGNED");

                    b.Property<int?>("CPAId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DollarThreshold")
                        .HasColumnType("INTEGER")
                        .HasColumnName("DOLLARTHRESHOLD");

                    b.Property<string>("EntityType")
                        .HasColumnType("TEXT")
                        .HasColumnName("ENTITY_TYPE");

                    b.Property<int>("FACDBKey")
                        .HasColumnType("INTEGER")
                        .HasColumnName("FAC_DBKEY");

                    b.Property<int>("FACReportId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("FAC_REPORTID");

                    b.Property<short?>("Numbermonths")
                        .HasColumnType("INTEGER")
                        .HasColumnName("NUMBERMONTHS");

                    b.Property<string>("Periodcovered")
                        .HasColumnType("TEXT")
                        .HasColumnName("PERIODCOVERED");

                    b.Property<string>("SuppressionCode")
                        .HasColumnType("TEXT")
                        .HasColumnName("SUPPRESSION_CODE");

                    b.Property<long>("TotalFederalExpendature")
                        .HasColumnType("INTEGER")
                        .HasColumnName("TOTFEDEXPEND");

                    b.Property<string>("TypeOfEntity")
                        .HasColumnType("TEXT")
                        .HasColumnName("TYPEOFENTITY");

                    b.Property<short>("Version")
                        .HasColumnType("INTEGER")
                        .HasColumnName("FAC_VERSION");

                    b.HasKey("Id");

                    b.HasIndex("AuditeeId");

                    b.HasIndex("CPAId");

                    b.ToTable("AUDIT_PACKAGES");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AuditTimeframe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AuditeeSubmitDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("AUDITEE_SUBMIT_DATE");

                    b.Property<DateTime>("AuditorSubmitDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("AUDITOR_SUBMIT_DATE");

                    b.Property<DateTime>("FACFirewallDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("FAC_FIREWALL_DATE");

                    b.Property<DateTime>("Fyenddate")
                        .HasColumnType("TEXT")
                        .HasColumnName("FYENDDATE");

                    b.Property<DateTime>("Fystartdate")
                        .HasColumnType("TEXT")
                        .HasColumnName("FYSTARTDATE");

                    b.Property<DateTime>("SystemImportDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("SYSTEM_IMPORT_DATE");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId")
                        .IsUnique();

                    b.ToTable("AUDIT_TIMEFRAMES");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Auditee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<string>("AuditeeEmail")
                        .HasColumnType("TEXT")
                        .HasColumnName("EMAIL");

                    b.Property<string>("AuditeeFax")
                        .HasColumnType("TEXT")
                        .HasColumnName("FAX");

                    b.Property<string>("AuditeePhone")
                        .HasColumnType("TEXT")
                        .HasColumnName("PHONE");

                    b.Property<string>("City")
                        .HasColumnType("TEXT")
                        .HasColumnName("CITY");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT")
                        .HasColumnName("CONTACT");

                    b.Property<string>("DUNS")
                        .HasColumnType("TEXT")
                        .HasColumnName("DUNS");

                    b.Property<string>("EIN")
                        .HasColumnType("TEXT")
                        .HasColumnName("EIN");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("NAME");

                    b.Property<string>("State")
                        .HasColumnType("TEXT")
                        .HasColumnName("STATE");

                    b.Property<string>("Street1")
                        .HasColumnType("TEXT")
                        .HasColumnName("STREET1");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT")
                        .HasColumnName("TITLE");

                    b.Property<string>("UEI")
                        .HasColumnType("TEXT")
                        .HasColumnName("UEI");

                    b.Property<string>("Zipcode")
                        .HasColumnType("TEXT")
                        .HasColumnName("ZIPCODE");

                    b.HasKey("Id");

                    b.ToTable("AUDITEES");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Award", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<bool>("ARRA")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ARRA");

                    b.Property<long>("Amount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("AMOUNT");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AwardIdentification")
                        .HasColumnType("TEXT")
                        .HasColumnName("AWARDIDENTIFICATION");

                    b.Property<string>("CFDAExt")
                        .HasColumnType("TEXT")
                        .HasColumnName("CFDA_EXT");

                    b.Property<string>("CFDAKey")
                        .HasColumnType("TEXT")
                        .HasColumnName("CFDA_KEY");

                    b.Property<string>("CFDAPrefix")
                        .HasColumnType("TEXT")
                        .HasColumnName("CFDA_PREFIX");

                    b.Property<string>("CFDASequenceNumber")
                        .HasColumnType("TEXT")
                        .HasColumnName("CFDASEQNUM");

                    b.Property<string>("ClusterName")
                        .HasColumnType("TEXT")
                        .HasColumnName("CLUSTERNAME");

                    b.Property<long?>("ClusterTotal")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CLUSTERTOTAL");

                    b.Property<string>("DefaultClusterName")
                        .HasColumnType("TEXT")
                        .HasColumnName("DEFAULT_CLUSTER_NAME");

                    b.Property<string>("DefaultProgramName")
                        .HasColumnType("TEXT")
                        .HasColumnName("DEFAULT_PROGRAM_NAME");

                    b.Property<bool>("Direct")
                        .HasColumnType("INTEGER")
                        .HasColumnName("DIRECT");

                    b.Property<string>("FederalProgramName")
                        .HasColumnType("TEXT")
                        .HasColumnName("FEDERALPROGRAMNAME");

                    b.Property<string>("FindingRefNums")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGREFNUMS");

                    b.Property<long?>("LoanBalance")
                        .HasColumnType("INTEGER")
                        .HasColumnName("LOANBALANCE");

                    b.Property<bool>("Loans")
                        .HasColumnType("INTEGER")
                        .HasColumnName("LOANS");

                    b.Property<bool>("MajorProgram")
                        .HasColumnType("INTEGER")
                        .HasColumnName("MAJORPROGRAM");

                    b.Property<string>("OtherClusterName")
                        .HasColumnType("TEXT")
                        .HasColumnName("OTHERCLUSTERNAME");

                    b.Property<long?>("PassthroughAmount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("PASSTHROUGHAMOUNT");

                    b.Property<string>("PassthroughAward")
                        .HasColumnType("TEXT")
                        .HasColumnName("PASSTHROUGHAWARD");

                    b.Property<long?>("ProgramTotal")
                        .HasColumnType("INTEGER")
                        .HasColumnName("PROGRAMTOTAL");

                    b.Property<bool>("RD")
                        .HasColumnType("INTEGER")
                        .HasColumnName("RD");

                    b.Property<string>("StateClustername")
                        .HasColumnType("TEXT")
                        .HasColumnName("STATECLUSTERNAME");

                    b.Property<string>("TypeReportMP")
                        .HasColumnType("TEXT")
                        .HasColumnName("TYPEREPORT_MP");

                    b.Property<string>("TypeRequirement")
                        .HasColumnType("TEXT")
                        .HasColumnName("TYPEREQUIREMENT");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("AWARDS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.CAPText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chartstables")
                        .HasColumnType("TEXT")
                        .HasColumnName("CHARTSTABLES");

                    b.Property<string>("Findingrefnums")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGREFNUMS");

                    b.Property<short>("SeqNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SEQ_NUMBER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT")
                        .HasColumnName("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("CAP_TEXT");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.CPA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<string>("City")
                        .HasColumnType("TEXT")
                        .HasColumnName("CITY");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT")
                        .HasColumnName("CONTACT");

                    b.Property<string>("EIN")
                        .HasColumnType("TEXT")
                        .HasColumnName("EIN");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Fax")
                        .HasColumnType("TEXT")
                        .HasColumnName("FAX");

                    b.Property<string>("Firmname")
                        .HasColumnType("TEXT")
                        .HasColumnName("FIRMNAME");

                    b.Property<bool>("Foreign")
                        .HasColumnType("INTEGER")
                        .HasColumnName("FOREIGN");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT")
                        .HasColumnName("PHONE");

                    b.Property<string>("State")
                        .HasColumnType("TEXT")
                        .HasColumnName("STATE");

                    b.Property<string>("Street1")
                        .HasColumnType("TEXT")
                        .HasColumnName("STREET1");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT")
                        .HasColumnName("TITLE");

                    b.Property<string>("Zipcode")
                        .HasColumnType("TEXT")
                        .HasColumnName("ZIPCODE");

                    b.HasKey("Id");

                    b.ToTable("CPAS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Finding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AwardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FindingRefNums")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGREFNUMS");

                    b.Property<bool>("MaterialWeakness")
                        .HasColumnType("INTEGER")
                        .HasColumnName("MATERIALWEAKNESS");

                    b.Property<bool>("ModifiedOpinion")
                        .HasColumnType("INTEGER")
                        .HasColumnName("MODIFIEDOPINION");

                    b.Property<bool>("OtherFindings")
                        .HasColumnType("INTEGER")
                        .HasColumnName("OTHERFINDINGS");

                    b.Property<bool>("OtherNonCompliance")
                        .HasColumnType("INTEGER")
                        .HasColumnName("OTHERNONCOMPLIANCE");

                    b.Property<string>("PriorFindingRefNums")
                        .HasColumnType("TEXT")
                        .HasColumnName("PRIORFINDINGREFNUMS");

                    b.Property<bool>("QCosts")
                        .HasColumnType("INTEGER")
                        .HasColumnName("QCOSTS");

                    b.Property<bool>("RepeatFinding")
                        .HasColumnType("INTEGER")
                        .HasColumnName("REPEATFINDING");

                    b.Property<string>("SignificantDeficiency")
                        .HasColumnType("TEXT")
                        .HasColumnName("SIGNIFICANTDEFICIENCY");

                    b.Property<string>("TypeRequirement")
                        .HasColumnType("TEXT")
                        .HasColumnName("TYPEREQUIREMENT");

                    b.HasKey("Id");

                    b.HasIndex("AwardId");

                    b.ToTable("FINDINGS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.FindingText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChartsTables")
                        .HasColumnType("TEXT")
                        .HasColumnName("CHARTSTABLES");

                    b.Property<string>("FindingRefNums")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGREFNUMS");

                    b.Property<short>("SeqNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SEQ_NUMBER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT")
                        .HasColumnName("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("FINDING_TEXT");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.FirewallDays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<DateTime>("FACFirewallDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("FAC_FIREWALL_DATE");

                    b.Property<short>("RecordsImported")
                        .HasColumnType("INTEGER")
                        .HasColumnName("RECORDS_IMPORTED");

                    b.Property<DateTime>("SystemImportDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("SYSTEM_IMPORT_DATE");

                    b.HasKey("Id");

                    b.ToTable("FIREWALL_DAYS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Passthrough", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PassthroughId")
                        .HasColumnType("TEXT")
                        .HasColumnName("PASSTHROUGHID");

                    b.Property<string>("PassthroughName")
                        .HasColumnType("TEXT")
                        .HasColumnName("PASSTHROUGHNAME");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("PASSTHROUGHS");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.ReportRevision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<string>("AuditInfo")
                        .HasColumnType("TEXT")
                        .HasColumnName("AUDITINFO");

                    b.Property<string>("AuditInfoExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("AUDITINFO_EXPLAIN");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CAP")
                        .HasColumnType("TEXT")
                        .HasColumnName("CAP");

                    b.Property<string>("CapExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("CAP_EXPLAIN");

                    b.Property<string>("FederalAwards")
                        .HasColumnType("TEXT")
                        .HasColumnName("FEDERALAWARDS");

                    b.Property<string>("FederalAwardsExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("FEDERALAWARDS_EXPLAIN");

                    b.Property<string>("Findings")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGS");

                    b.Property<string>("FindingsExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGS_EXPLAIN");

                    b.Property<string>("FindingsText")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGSTEXT");

                    b.Property<string>("FindingsTextExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINDINGSTEXT_EXPLAIN");

                    b.Property<string>("GenInfo")
                        .HasColumnType("TEXT")
                        .HasColumnName("GENINFO");

                    b.Property<string>("GenInfoExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("GENINFO_EXPLAIN");

                    b.Property<string>("NotesToSEFA")
                        .HasColumnType("TEXT")
                        .HasColumnName("NOTESTOSEFA");

                    b.Property<string>("NotesToSEFAExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("NOTESTOSEFA_EXPLAIN");

                    b.Property<string>("Other")
                        .HasColumnType("TEXT")
                        .HasColumnName("OTHER");

                    b.Property<string>("OtherExplain")
                        .HasColumnType("TEXT")
                        .HasColumnName("OTHER_EXPLAIN");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("ReportRevisions");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.ReportedAgency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<string>("Agencycfda")
                        .HasColumnType("TEXT")
                        .HasColumnName("AGENCYCFDA");

                    b.Property<int?>("AuditPackageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Currentfinding")
                        .HasColumnType("TEXT")
                        .HasColumnName("CURRENTFINDING");

                    b.Property<string>("Final")
                        .HasColumnType("TEXT")
                        .HasColumnName("FINAL");

                    b.Property<string>("PriorFinding")
                        .HasColumnType("TEXT")
                        .HasColumnName("PRIORFINDING");

                    b.Property<string>("PyAgency")
                        .HasColumnType("TEXT")
                        .HasColumnName("PYAGENCY");

                    b.HasKey("Id");

                    b.HasIndex("AuditPackageId");

                    b.ToTable("ReportedAgencies");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AdditionalDUN", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("AddtionalDUNs")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AdditionalEIN", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("AddtionalEINs")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AdditionalUEI", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("AdditionalUEIs")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AuditIndicators", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", "AuditPackage")
                        .WithOne("AuditIndicators")
                        .HasForeignKey("AuditImportService.Data.Entities.AuditIndicators", "AuditPackageId");

                    b.Navigation("AuditPackage");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AuditPackage", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.Auditee", "Auditee")
                        .WithMany("AuditPackages")
                        .HasForeignKey("AuditeeId");

                    b.HasOne("AuditImportService.Data.Entities.CPA", "CPA")
                        .WithMany("AuditPackages")
                        .HasForeignKey("CPAId");

                    b.Navigation("Auditee");

                    b.Navigation("CPA");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AuditTimeframe", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", "AuditPackage")
                        .WithOne("AuditTimeframe")
                        .HasForeignKey("AuditImportService.Data.Entities.AuditTimeframe", "AuditPackageId");

                    b.Navigation("AuditPackage");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Award", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("Awards")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.CAPText", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("CapText")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Finding", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.Award", null)
                        .WithMany("Findings")
                        .HasForeignKey("AwardId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.FindingText", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("FindingTexts")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Passthrough", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("Passthroughs")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.ReportRevision", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("ReportRevisions")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.ReportedAgency", b =>
                {
                    b.HasOne("AuditImportService.Data.Entities.AuditPackage", null)
                        .WithMany("ReportedAgencies")
                        .HasForeignKey("AuditPackageId");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.AuditPackage", b =>
                {
                    b.Navigation("AdditionalUEIs");

                    b.Navigation("AddtionalDUNs");

                    b.Navigation("AddtionalEINs");

                    b.Navigation("AuditIndicators");

                    b.Navigation("AuditTimeframe");

                    b.Navigation("Awards");

                    b.Navigation("CapText");

                    b.Navigation("FindingTexts");

                    b.Navigation("Passthroughs");

                    b.Navigation("ReportRevisions");

                    b.Navigation("ReportedAgencies");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Auditee", b =>
                {
                    b.Navigation("AuditPackages");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.Award", b =>
                {
                    b.Navigation("Findings");
                });

            modelBuilder.Entity("AuditImportService.Data.Entities.CPA", b =>
                {
                    b.Navigation("AuditPackages");
                });
#pragma warning restore 612, 618
        }
    }
}
