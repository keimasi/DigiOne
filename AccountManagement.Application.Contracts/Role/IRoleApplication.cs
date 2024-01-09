using System.Collections.Generic;
using _0_Framwork.Application;

namespace AccountManagement.Application.Contracts.Role
{
    public interface IRoleApplication
    {
        OperationResult Create(CreateRole command);
        OperationResult Edit(EditRole command);
        EditRole GetDetail(int id);
        List<RoleViewModel> GetRoles();
    }
}