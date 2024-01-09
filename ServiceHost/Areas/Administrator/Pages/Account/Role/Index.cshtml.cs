using System.Collections.Generic;
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administrator.Pages.Account.Role
{
    public class IndexModel : PageModel
    {
        public List<RoleViewModel> RoleViewModels;

        private readonly IRoleApplication _roleApplication;

        public IndexModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }

        public void OnGet()
        {
            RoleViewModels = _roleApplication.GetRoles();
        }
    }
}
