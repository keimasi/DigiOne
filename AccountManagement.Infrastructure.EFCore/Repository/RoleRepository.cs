using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.Role;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class RoleRepository : RepositoryBace<int, RoleEntity>, IRoleRepository
    {
        private readonly AccountContext _context;

        public RoleRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public EditRole GetDetail(int id)
        {
            var role = _context.Roles.Select(x => new EditRole
            {
                Id = x.Id,
                Name = x.Name,
                MappedPermissions = MapPermission(x.Permissions)
            }).AsNoTracking().FirstOrDefault(x => x.Id == id);

            role.Permissions = role.MappedPermissions.Select(x => x.Code).ToList();

            return role;
        }

        private static List<PermissionDto> MapPermission(List<Permission> permissions)
        {
            return permissions.Select(x => new PermissionDto(x.Code, x.Name)).ToList();
        }

        public List<RoleViewModel> GetRoles()
        {
            return _context.Roles.Select(x => new RoleViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CreateDate = x.CreateDate.ToFarsi()
            }).ToList();
        }
    }
}
