using _0_Framwork.Domain;
using AccountManagement.Domain.Role;

namespace AccountManagement.Domain.Account
{
    public class AccountEntity : EntityBace
    {
        public string FullName { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }

        public int RoleId { get; private set; }
        public RoleEntity Role { get; private set; }

        public AccountEntity(string fullName, string userName, string password, string mobile, int roleId)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
            Mobile = mobile;
            RoleId = roleId == 0 ? 1 : roleId;
        }

        public void Edit(string fullName, string userName, string mobile, int roleId)
        {
            FullName = fullName;
            UserName = userName;
            Mobile = mobile;
            RoleId = roleId;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

    }
}
