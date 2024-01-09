using _0_Framwork.Domain;

namespace AccountManagement.Domain.Role
{
    public class Permission : EntityBace
    {
        public int Code { get; private set; }
        public string Name { get; private set; }

        public int RoleId { get; private set; }
        public RoleEntity Role { get; private set; }

        public Permission(int code)
        {
            Code = code;
        }

        public Permission(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
