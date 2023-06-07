using System.Threading.Tasks;
using Abp.Application.Services;
using azuretest.Sessions.Dto;

namespace azuretest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
