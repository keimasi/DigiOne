using System.Collections.Generic;
using _0_Framwork.Application;

namespace AccountManagement.Application.Contracts.Account
{
    public interface IAccountApplication
    {
        OperationResult Create(CreateAccount command);
        OperationResult Edit(EditAccount command);
        OperationResult ChangePassword(ChangePassword command);
        OperationResult Login(Login command);
        void Logout();
        EditAccount GetDetails(int id);
        List<AccountViewModel> GetAccounts();
    }
}
