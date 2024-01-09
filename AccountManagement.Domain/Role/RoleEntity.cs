using System.Collections.Generic;
using _0_Framwork.Domain;
using AccountManagement.Domain.Account;

namespace AccountManagement.Domain.Role
{
    public class RoleEntity : EntityBace
    {
        public string Name { get; private set; }
        public List<AccountEntity> Accounts { get; private set; }
        public List<Permission> Permissions { get; private set; }

        protected RoleEntity()
        {
        }

        public RoleEntity(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
        }

        public void Edit(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
        } 
    }
}
