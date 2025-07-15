using Volo.Abp.Modularity;

namespace Repro.LocalizationAndAuthGuard;

public abstract class LocalizationAndAuthGuardApplicationTestBase<TStartupModule> : LocalizationAndAuthGuardTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
