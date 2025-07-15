using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Repro.LocalizationAndAuthGuard.Data;

/* This is used if database provider does't define
 * ILocalizationAndAuthGuardDbSchemaMigrator implementation.
 */
public class NullLocalizationAndAuthGuardDbSchemaMigrator : ILocalizationAndAuthGuardDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
