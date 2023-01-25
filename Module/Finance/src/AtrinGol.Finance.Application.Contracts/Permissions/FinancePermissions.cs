using Volo.Abp.Reflection;

namespace AtrinGol.Finance.Permissions;

public class FinancePermissions
{
    public const string GroupName = "Finance";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(FinancePermissions));
    }
}
