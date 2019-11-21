using System.Threading.Tasks;
using taskManager.Configuration.Dto;

namespace taskManager.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
