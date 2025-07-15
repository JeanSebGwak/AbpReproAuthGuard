using Microsoft.Extensions.Localization;
using Repro.LocalizationAndAuthGuard.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Repro.LocalizationAndAuthGuard;

[Dependency(ReplaceServices = true)]
public class LocalizationAndAuthGuardBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<LocalizationAndAuthGuardResource> _localizer;

    public LocalizationAndAuthGuardBrandingProvider(IStringLocalizer<LocalizationAndAuthGuardResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
