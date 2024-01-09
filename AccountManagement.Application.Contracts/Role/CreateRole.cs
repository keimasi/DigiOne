using System.Collections.Generic;
using _0_Framwork.Infrastructure;

namespace AccountManagement.Application.Contracts.Role
{
    public class CreateRole
    {
        public string Name { get; set; }
        public List<int> Permissions { get; set; }
    }
}
