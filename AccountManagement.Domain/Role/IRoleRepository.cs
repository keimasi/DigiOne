using System.Collections.Generic;
using _0_Framwork.Domain;
using AccountManagement.Application.Contracts.Role;

namespace AccountManagement.Domain.Role
{
    public interface IRoleRepository : IRepository<int, RoleEntity>
    {
        EditRole GetDetail(int id);
        List<RoleViewModel> GetRoles();
    }
}
