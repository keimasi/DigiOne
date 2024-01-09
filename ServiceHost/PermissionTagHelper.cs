using System.Linq;
using _0_Framwork.Application;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ServiceHost
{
    [HtmlTargetElement(Attributes = "Permission")]
    public class PermissionTagHelper : TagHelper
    {
        public int Permission { get; set; }
        private readonly IAuthenticationHelper _authenticationHelper;

        public PermissionTagHelper(IAuthenticationHelper authenticationHelper)
        {
            _authenticationHelper = authenticationHelper;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!_authenticationHelper.IsAuthenticated())
            {
                output.SuppressOutput();
                return;
            }

            var permission = _authenticationHelper.GetPermissions();
            if (permission.All(x => x != Permission))
            {
                output.SuppressOutput();
                return;
            }

            base.Process(context, output);
        }
    }
}
