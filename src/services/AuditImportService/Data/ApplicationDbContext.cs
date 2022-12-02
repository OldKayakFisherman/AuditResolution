using AuditImportService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuditImportService.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<AdditionalDUN> AdditionalDUNs { get; set; }
    public DbSet<AdditionalEIN> AdditionalEINs { get; set; }
    public DbSet<AdditionalUEI> AdditionalUEIs { get; set; }
    public DbSet<Agency> Agencies { get; set; }
    public DbSet<Auditee> Auditees { get; set; }
    public DbSet<AuditIndicators> AuditIndicators { get; set; }
    public DbSet<AuditPackage> AuditPackages { get; set; }
    public DbSet<AuditTimeframe> AuditTimeframes { get; set; }
    public DbSet<Award> Awards { get; set; }
    public DbSet<CAPText> CapTexts { get; set; }
    public DbSet<CPA> CPAs { get; set; }
    public DbSet<Finding> Findings { get; set; }
    public DbSet<FindingText> FindingTexts { get; set; }
    public DbSet<FirewallDays> FirewallDays { get; set; }
    public DbSet<Passthrough> Passthroughs { get; set; }
    public DbSet<ReportedAgency> ReportedAgencies { get; set; }
    public DbSet<ReportRevision> ReportRevisions { get; set; }
    public DbSet<SystemError> SystemErrors { get; set; }
    public DbSet<TrafficLog> TrafficLogs { get; set; }

}