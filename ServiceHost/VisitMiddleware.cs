using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ReportManagement.Application.Contracts.SiteVisit;

namespace ServiceHost
{
    public class VisitMiddleware
    {
        private readonly RequestDelegate _next;

        public VisitMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task Invoke(HttpContext context, ISiteVisitApplication visitApplication)
        {
            string ipAddress = context.Connection.RemoteIpAddress?.ToString();
            visitApplication.LogVisitAdd(ipAddress);

            await _next(context);
        }
    }
}