using Desk.Gist.ABPDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Desk.Gist.ABPDemo.Permissions
{
    public class ABPDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ABPDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ABPDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ABPDemoResource>(name);
        }
    }
}
