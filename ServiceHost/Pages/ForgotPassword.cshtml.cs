using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ForgotPasswordModel : PageModel
    {
        [TempData]
        public string ForgotPassMessage { get; set; }

        private readonly IAccountApplication _accountApplication;

        public ForgotPasswordModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(ForgotPassword command)
        {
            var result = _accountApplication.ForgotPassword(command);

            ForgotPassMessage = result.Message;

            if (result.IsSuccess)
            {
                return RedirectToPage("/Login", new {ForgotPassMessage});
            }

            return Page();
        }
    }
}
