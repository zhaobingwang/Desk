using Desk.Gist.ABPDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Desk.Gist.ABPDemo.Permissions
{
    public class ABPDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(ABPDemoPermissions.GroupName, L("Permission:BookStore"));
            var booksPermission = bookStoreGroup.AddPermission(ABPDemoPermissions.Books.Default, L("Permission:Books"));
            booksPermission.AddChild(ABPDemoPermissions.Books.Create, L("Permission:Books.Create"));
            booksPermission.AddChild(ABPDemoPermissions.Books.Edit, L("Permission:Books.Edit"));
            booksPermission.AddChild(ABPDemoPermissions.Books.Delete, L("Permission:Books.Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ABPDemoResource>(name);
        }
    }
}
