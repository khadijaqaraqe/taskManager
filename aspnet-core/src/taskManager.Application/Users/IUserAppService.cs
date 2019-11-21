using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using taskManager.Roles.Dto;
using taskManager.Users.Dto;

namespace taskManager.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
