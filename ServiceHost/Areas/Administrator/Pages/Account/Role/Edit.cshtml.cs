using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Infrastructure;
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Administrator.Pages.Account.Role
{
    public class EditModel : PageModel
    {
        public EditRole Command;
        public List<SelectListItem> Permissions = new List<SelectListItem>();

        private readonly IRoleApplication _roleApplication;
        private readonly IEnumerable<IPermissionExposer> _exposer;

        public EditModel(IRoleApplication roleApplication, IEnumerable<IPermissionExposer> exposer)
        {
            _roleApplication = roleApplication;
            _exposer = exposer;
        }

        public void OnGet(int id)
        {
            Command = _roleApplication.GetDetail(id);
            var permissions = new List<PermissionDto>();

            foreach (var exposer in _exposer)
            {
                var exposedPermissions = exposer.Expose();

                foreach (var (key, value) in exposedPermissions)
                {
                    permissions.AddRange(value);

                    var group = new SelectListGroup
                    {
                        Name = key
                    };

                    foreach (var permission in value)
                    {
                        var item = new SelectListItem(permission.Name, permission.Code.ToString())
                        {
                            Group = group
                        };

                        if (Command.MappedPermissions.Any(x => x.Code == permission.Code))
                            item.Selected = true;

                        Permissions.Add(item);
                    }
                }
            }
        }

        public IActionResult OnPost(EditRole command)
        {
            var result = _roleApplication.Edit(command);
            return RedirectToPage("Index");
        }
    }
}
