using System;
using System.Collections.Generic;
using System.Text;
using Repro.LocalizationAndAuthGuard.Localization;
using Volo.Abp.Application.Services;

namespace Repro.LocalizationAndAuthGuard;

/* Inherit your application services from this class.
 */
public abstract class LocalizationAndAuthGuardAppService : ApplicationService
{
    protected LocalizationAndAuthGuardAppService()
    {
        LocalizationResource = typeof(LocalizationAndAuthGuardResource);
    }
}
