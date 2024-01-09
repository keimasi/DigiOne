using System.Collections.Generic;
using _0_Framwork.Infrastructure;

namespace AccountManagement.Application.Contracts.Role
{
    public class EditRole : CreateRole
    {
        public int Id { get; set; }
        public List<PermissionDto> MappedPermissions { get; set; }
    }
}