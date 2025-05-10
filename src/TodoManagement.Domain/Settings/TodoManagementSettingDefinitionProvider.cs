using Volo.Abp.Settings;

namespace TodoManagement.Settings;

public class TodoManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TodoManagementSettings.MySetting1));
    }
}
