using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class LoginModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        private readonly IAccountApplication _accountApplication;

        public LoginModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet(string forgotPassMessage)
        {
            Message = forgotPassMessage;
        }

        public IActionResult OnPost(Login command, string returnUrl)
        {
            var result = _accountApplication.Login(command);
            if (result.IsSuccess)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return LocalRedirect(returnUrl);
                }
                return RedirectToPage("/Index");
            }

            Message = result.Message;
            return Page();
        }

        public RedirectToPageResult OnGetLogOut()
        {
            _accountApplication.Logout();
            return RedirectToPage("/Index");
        }
    }
}
