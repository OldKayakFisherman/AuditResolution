using AuditImportService.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace AuditImportService.Tests;

public class LocalDBHelper
{
    private static DbContextOptions<ApplicationDbContext> CreateOptions()
    {
        //This creates the SQLite connection string to in-memory database
        var connectionStringBuilder = new SqliteConnectionStringBuilder
            { DataSource = ":memory:" };
        var connectionString = connectionStringBuilder.ToString();

        //This creates a SqliteConnectionwith that string
        var connection = new SqliteConnection(connectionString);

        //The connection MUST be opened here
        connection.Open();

        //Now we have the EF Core commands to create SQLite options
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        builder.UseSqlite(connection);
        
        return builder.Options;
    }

    public static ApplicationDbContext CreateDbContext() 
    {
        var options = CreateOptions();

        var ctx = new ApplicationDbContext(options);

        ctx.Database.EnsureCreated();

        return ctx;

    }

}