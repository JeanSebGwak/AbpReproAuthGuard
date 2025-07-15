using Repro.LocalizationAndAuthGuard.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Repro.LocalizationAndAuthGuard.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LocalizationAndAuthGuardEntityFrameworkCoreModule),
    typeof(LocalizationAndAuthGuardApplicationContractsModule)
    )]
public class LocalizationAndAuthGuardDbMigratorModule : AbpModule
{
}
