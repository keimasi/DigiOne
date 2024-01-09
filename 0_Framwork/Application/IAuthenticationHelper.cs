using System.Collections.Generic;

namespace _0_Framwork.Application
{
    public interface IAuthenticationHelper
    {
        void Signin(AuthenticationViewModel account);
        void SignOut();
        bool IsAuthenticated();
        AuthenticationViewModel CurrentUserInfo();
        List<int> GetPermissions();
    }
}
