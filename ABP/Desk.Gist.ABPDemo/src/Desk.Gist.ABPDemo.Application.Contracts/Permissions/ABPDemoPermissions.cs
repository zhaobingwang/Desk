﻿namespace Desk.Gist.ABPDemo.Permissions
{
    public static class ABPDemoPermissions
    {
        public const string GroupName = "ABPDemo";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static class Books
        {
            public const string Default = GroupName + ".Books";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }
}