using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk
{
    public static class DbPreConfigure
    {
        /// <summary>
        /// 定义默认表名前缀
        /// </summary>
        public static void ConfigurePrefix()
        {
            // 定义默认表前缀
            // Volo.Abp.Data.AbpCommonDbProperties.DbTablePrefix = "Sys";
            Volo.Abp.IdentityServer.AbpIdentityServerDbProperties.DbTablePrefix = "SysIdentity";
            Volo.Abp.Identity.AbpIdentityDbProperties.DbTablePrefix = "Sys";
            Volo.Abp.AuditLogging.AbpAuditLoggingDbProperties.DbTablePrefix = "Sys";
            Volo.Abp.BackgroundJobs.BackgroundJobsDbProperties.DbTablePrefix = "Sys";
            Volo.Abp.PermissionManagement.AbpPermissionManagementDbProperties.DbTablePrefix = "Sys";
            Volo.Abp.FeatureManagement.FeatureManagementDbProperties.DbTablePrefix = "Sys";
            Volo.Abp.SettingManagement.AbpSettingManagementDbProperties.DbTablePrefix = "Sys";
            Volo.Abp.TenantManagement.AbpTenantManagementDbProperties.DbTablePrefix = "Sys";
        }
    }
}
