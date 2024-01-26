using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace _0_Framwork.Application
{
    public class AuthenticationHelper : IAuthenticationHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public AuthenticationHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public void Signin(AuthenticationViewModel account)
        {
            var permissions = JsonConvert.SerializeObject(account.Permissions);

            var claims = new List<Claim>
            {
                new Claim("AccountId",account.Id.ToString()),
                new Claim(ClaimTypes.Name,account.FullName),
                new Claim(ClaimTypes.Role,account.RoleId.ToString()),
                new Claim("UserName",account.Username),
                new Claim("Permissions",permissions)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1)
            };

            _contextAccessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }

        public void SignOut()
        {
            _contextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public bool IsAuthenticated()
        {
            return _contextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public AuthenticationViewModel CurrentUserInfo()
        {
            var result = new AuthenticationViewModel();

            if (!IsAuthenticated())
                return result;

            var claims = _contextAccessor.HttpContext.User.Claims.ToList();
            result.Id = int.Parse(claims.FirstOrDefault(x => x.Type == "AccountId").Value);
            result.Username = claims.FirstOrDefault(x => x.Type == "UserName").Value;
            result.RoleId = int.Parse(claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value);
            result.FullName = claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;

            return result;
        }

        public List<int> GetPermissions()
        {
            if (!IsAuthenticated())
                return new List<int>();

            var permissions = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Permissions")
                ?.Value;
            return JsonConvert.DeserializeObject<List<int>>(permissions);
        }

        public int GetCurrentUserId()
        {
            return IsAuthenticated() ? int.Parse(_contextAccessor.HttpContext.User.Claims.First(x=>x.Type=="AccountId")?.Value) : 0;
        }
    }
}