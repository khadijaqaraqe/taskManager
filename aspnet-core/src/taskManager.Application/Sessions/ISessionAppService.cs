using System.Threading.Tasks;
using Abp.Application.Services;
using taskManager.Sessions.Dto;

namespace taskManager.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
