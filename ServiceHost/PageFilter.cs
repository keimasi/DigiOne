using System.Linq;
using System.Reflection;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ServiceHost
{
    public class PageFilter : IPageFilter
    {
        private readonly IAuthenticationHelper _authenticationHelper;

        public PageFilter(IAuthenticationHelper authenticationHelper)
        {
            _authenticationHelper = authenticationHelper;
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            var handlerPermission = (NeedsPermissionAttribute)context.HandlerMethod.MethodInfo.GetCustomAttribute(typeof(NeedsPermissionAttribute));

            if (handlerPermission == null)
                return;

            var UserPermissions = _authenticationHelper.GetPermissions();

            if (UserPermissions.All(x => x != handlerPermission.Permission))
                context.HttpContext.Response.Redirect("/Login");
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }
    }
}
