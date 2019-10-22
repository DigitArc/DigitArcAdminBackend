using Volo.Abp.Settings;

namespace DigitArc.AdminBackend.Settings
{
    public class AdminBackendSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AdminBackendSettings.MySetting1));
        }
    }
}
