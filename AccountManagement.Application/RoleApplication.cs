using System.Collections.Generic;
using _0_Framwork.Application;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.Role;

namespace AccountManagement.Application
{
    public class RoleApplication : IRoleApplication
    {
        private readonly IRoleRepository _roleRepository;

        public RoleApplication(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public OperationResult Create(CreateRole command)
        {
            var operation = new OperationResult();
            if (_roleRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var role = new RoleEntity(command.Name, new List<Permission>());
            _roleRepository.Create(role);
            _roleRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditRole command)
        {
            var operation = new OperationResult();
            var role = _roleRepository.Get(command.Id);

            if (role == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_roleRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var permissions = new List<Permission>();
            command.Permissions.ForEach(code => permissions.Add(new Permission(code)));

            role.Edit(command.Name,permissions);
            _roleRepository.Save();
            return operation.Success();
        }

        public EditRole GetDetail(int id)
        {
            return _roleRepository.GetDetail(id);
        }

        public List<RoleViewModel> GetRoles()
        {
            return _roleRepository.GetRoles();
        }
    }
}
