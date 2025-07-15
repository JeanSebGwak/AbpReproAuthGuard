using Volo.Abp.Modularity;

namespace Repro.LocalizationAndAuthGuard;

[DependsOn(
    typeof(LocalizationAndAuthGuardDomainModule),
    typeof(LocalizationAndAuthGuardTestBaseModule)
)]
public class LocalizationAndAuthGuardDomainTestModule : AbpModule
{

}
