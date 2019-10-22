using DigitArc.AdminBackend.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DigitArc.AdminBackend.Permissions
{
    public class AdminBackendPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AdminBackendPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AdminBackendPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AdminBackendResource>(name);
        }
    }
}
