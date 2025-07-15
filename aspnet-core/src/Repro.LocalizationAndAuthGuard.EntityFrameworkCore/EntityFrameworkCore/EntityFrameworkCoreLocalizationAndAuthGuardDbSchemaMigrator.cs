using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repro.LocalizationAndAuthGuard.Data;
using Volo.Abp.DependencyInjection;

namespace Repro.LocalizationAndAuthGuard.EntityFrameworkCore;

public class EntityFrameworkCoreLocalizationAndAuthGuardDbSchemaMigrator
    : ILocalizationAndAuthGuardDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLocalizationAndAuthGuardDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the LocalizationAndAuthGuardDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LocalizationAndAuthGuardDbContext>()
            .Database
            .MigrateAsync();
    }
}
