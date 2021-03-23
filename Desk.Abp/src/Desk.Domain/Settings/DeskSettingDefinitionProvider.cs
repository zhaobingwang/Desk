using Volo.Abp.Settings;

namespace Desk.Settings
{
    public class DeskSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DeskSettings.MySetting1));
        }
    }
}
