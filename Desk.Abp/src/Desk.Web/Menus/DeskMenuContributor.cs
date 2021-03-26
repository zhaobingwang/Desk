﻿using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Desk.Localization;
using Desk.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Desk.Web.Menus
{
    public class DeskMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<DeskResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(DeskMenus.Home, l["Menu:Home"], "~/"));



            #region 添加业务菜单
            var assetMenu = new ApplicationMenuItem(
                "Assets",
                l["Menu:Assets"],
                icon: "fa fa-book"
            );

            context.Menu.AddItem(assetMenu);

            assetMenu.AddItem(new ApplicationMenuItem(
                "Assets.Categories",
                l["Menu:AssetCategories"],
                url: "/AssetCategories"
            ));
            #endregion
        }
    }
}