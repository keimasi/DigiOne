using System.Collections.Generic;

namespace _0_Framwork.Application
{
    public class AuthenticationViewModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public List<int> Permissions { get; set; }

        public AuthenticationViewModel()
        {
        }

        public AuthenticationViewModel(int id, int roleId, string fullName, string username, List<int> permissions)
        {
            Id = id;
            RoleId = roleId;
            FullName = fullName;
            Username = username;
            Permissions = permissions;
        }
    }
}