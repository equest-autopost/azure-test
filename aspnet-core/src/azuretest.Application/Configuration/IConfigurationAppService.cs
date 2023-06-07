using System.Threading.Tasks;
using azuretest.Configuration.Dto;

namespace azuretest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
