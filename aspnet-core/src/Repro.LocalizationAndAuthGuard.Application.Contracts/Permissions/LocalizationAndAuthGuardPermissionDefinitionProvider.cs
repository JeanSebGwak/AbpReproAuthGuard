using Repro.LocalizationAndAuthGuard.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Repro.LocalizationAndAuthGuard.Permissions;

public class LocalizationAndAuthGuardPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LocalizationAndAuthGuardPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LocalizationAndAuthGuardPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LocalizationAndAuthGuardResource>(name);
    }
}
