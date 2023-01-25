using AtrinGol.Contract.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AtrinGol.Contract.Permissions;

public class ContractPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ContractPermissions.GroupName, L("Permission:Contract"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ContractResource>(name);
    }
}
