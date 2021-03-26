namespace Desk.Permissions
{
    public static class DeskPermissions
    {
        public const string GroupName = "Desk";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static class AssetCategories
        {
            public const string Default = GroupName + ".Asset.Category";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        public static class AssetRecords
        {
            public const string Default = GroupName + ".Asset.Record";
            public const string Create = GroupName + ".Create";
            public const string Edit = GroupName + ".Edit";
            public const string Delete = GroupName + ".Delete";
        }
    }
}