﻿using Volo.Abp.Settings;

namespace Desk.Gist.ABPDemo.Settings
{
    public class ABPDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ABPDemoSettings.MySetting1));
        }
    }
}
