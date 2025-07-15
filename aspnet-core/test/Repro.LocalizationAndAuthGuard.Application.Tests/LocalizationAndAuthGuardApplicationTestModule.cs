using Volo.Abp.Modularity;

namespace Repro.LocalizationAndAuthGuard;

[DependsOn(
    typeof(LocalizationAndAuthGuardApplicationModule),
    typeof(LocalizationAndAuthGuardDomainTestModule)
)]
public class LocalizationAndAuthGuardApplicationTestModule : AbpModule
{

}
