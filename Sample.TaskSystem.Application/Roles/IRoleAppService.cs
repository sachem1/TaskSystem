using System.Threading.Tasks;
using Abp.Application.Services;
using Sample.TaskSystem.Roles.Dto;

namespace Sample.TaskSystem.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
