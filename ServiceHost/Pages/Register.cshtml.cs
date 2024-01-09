using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class RegisterModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        private readonly IAccountApplication _accountApplication;

        public RegisterModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostRegister(CreateAccount command)
        {
            var result = _accountApplication.Create(command);
            if (result.IsSuccess)
                return RedirectToPage("/Login");

            Message = result.Message;
            return Page();
        }
    }
}
