using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;
using AccountManagement.Application.Contracts.Role;

namespace AccountManagement.Application.Contracts.Account
{
    public class CreateAccount
    {
        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string FullName { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string UserName { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Password { get; set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Mobile { get; set; }

        public int RoleId { get; set; }

        public List<RoleViewModel> Roles { get; set; }
    }
}
