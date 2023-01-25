using Volo.Abp.Reflection;

namespace AtrinGol.Contract.Permissions;

public class ContractPermissions
{
    public const string GroupName = "Contract";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ContractPermissions));
    }
}
