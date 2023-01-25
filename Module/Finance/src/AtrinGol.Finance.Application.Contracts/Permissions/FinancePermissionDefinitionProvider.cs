using AtrinGol.Finance.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AtrinGol.Finance.Permissions;

public class FinancePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FinancePermissions.GroupName, L("Permission:Finance"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FinanceResource>(name);
    }
}
