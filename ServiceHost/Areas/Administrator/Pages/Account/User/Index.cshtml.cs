using System.Collections.Generic;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administrator.Pages.Account.User
{
    public class IndexModel : PageModel
    {
        public List<AccountViewModel> AccountList;

        private readonly IRoleApplication _roleApplication;
        private readonly IAccountApplication _accountApplication;

        public IndexModel(IAccountApplication accountApplication, IRoleApplication roleApplication)
        {
            _accountApplication = accountApplication;
            _roleApplication = roleApplication;
        }

        public void OnGet()
        {
            AccountList = _accountApplication.GetAccounts();
        }
        
        public IActionResult OnGetCreate()
        {
            var command = new CreateAccount()
            {
                Roles= _roleApplication.GetRoles()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateAccount command)
        {
            var result = _accountApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(int id)
        {
            var account = _accountApplication.GetDetails(id);
            account.Roles = _roleApplication.GetRoles();
            return Partial("Edit", account);
        }

        public JsonResult OnPostEdit(EditAccount command)
        {
            var result = _accountApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetChangePassword(int id)
        {
            var command = new ChangePassword
            {
                Id = id
            };
            return Partial("ChangePassword", command);
        }

        public JsonResult OnPostChangePassword(ChangePassword command)
        {
            var result = _accountApplication.ChangePassword(command);
            return new JsonResult(result);
        }
    }
}
