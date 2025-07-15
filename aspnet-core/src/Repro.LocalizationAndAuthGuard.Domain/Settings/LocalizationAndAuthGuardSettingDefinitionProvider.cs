using Volo.Abp.Settings;

namespace Repro.LocalizationAndAuthGuard.Settings;

public class LocalizationAndAuthGuardSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LocalizationAndAuthGuardSettings.MySetting1));
    }
}
