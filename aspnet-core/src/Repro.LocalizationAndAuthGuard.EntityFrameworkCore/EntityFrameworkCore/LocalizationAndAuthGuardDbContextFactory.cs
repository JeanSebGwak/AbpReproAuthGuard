using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Repro.LocalizationAndAuthGuard.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class LocalizationAndAuthGuardDbContextFactory : IDesignTimeDbContextFactory<LocalizationAndAuthGuardDbContext>
{
    public LocalizationAndAuthGuardDbContext CreateDbContext(string[] args)
    {
        LocalizationAndAuthGuardEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<LocalizationAndAuthGuardDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new LocalizationAndAuthGuardDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Repro.LocalizationAndAuthGuard.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
