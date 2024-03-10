using System.ComponentModel.DataAnnotations;
using _0_Framwork.Application;

namespace AccountManagement.Application.Contracts.Account
{
    public class ForgotPassword
    {
        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string UserName { get; set; }
    }
}
