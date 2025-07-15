using Volo.Abp.Modularity;

namespace Repro.LocalizationAndAuthGuard;

/* Inherit from this class for your domain layer tests. */
public abstract class LocalizationAndAuthGuardDomainTestBase<TStartupModule> : LocalizationAndAuthGuardTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
