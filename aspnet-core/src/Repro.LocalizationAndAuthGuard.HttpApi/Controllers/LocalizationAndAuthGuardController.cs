using Repro.LocalizationAndAuthGuard.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Repro.LocalizationAndAuthGuard.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LocalizationAndAuthGuardController : AbpControllerBase
{
    protected LocalizationAndAuthGuardController()
    {
        LocalizationResource = typeof(LocalizationAndAuthGuardResource);
    }
}
