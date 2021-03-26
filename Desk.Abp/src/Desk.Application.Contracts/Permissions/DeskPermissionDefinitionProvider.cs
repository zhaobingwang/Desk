using Desk.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Desk.Permissions
{
    public class DeskPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var deskGroup = context.AddGroup(DeskPermissions.GroupName, L("Permission:Desk")); ;

            // Asset-Category
            var assetCategoryPermission = deskGroup.AddPermission(DeskPermissions.AssetCategories.Default, L("Permission:Asset:Category"));
            assetCategoryPermission.AddChild(DeskPermissions.AssetCategories.Create, L("Permission:Asset:Category.Create"));
            assetCategoryPermission.AddChild(DeskPermissions.AssetCategories.Edit, L("Permission:Asset:Category.Edit"));
            assetCategoryPermission.AddChild(DeskPermissions.AssetCategories.Delete, L("Permission:Asset:Category.Delete"));

            // Asset-Record
            var assetRecordPermission = deskGroup.AddPermission(DeskPermissions.AssetRecords.Default, L("Permission:Asset:Record"));
            assetRecordPermission.AddChild(DeskPermissions.AssetRecords.Create, L("Permission:Asset:Record.Create"));
            assetRecordPermission.AddChild(DeskPermissions.AssetRecords.Edit, L("Permission:Asset:Record.Edit"));
            assetRecordPermission.AddChild(DeskPermissions.AssetRecords.Delete, L("Permission:Asset:Record.Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DeskResource>(name);
        }
    }
}
