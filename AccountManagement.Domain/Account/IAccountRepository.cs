using System.Collections.Generic;
using _0_Framwork.Domain;
using AccountManagement.Application.Contracts.Account;

namespace AccountManagement.Domain.Account
{
    public interface IAccountRepository : IRepository<int, AccountEntity>
    {
        EditAccount GetDetails(int id);
        AccountEntity GetBy(string username);
        List<AccountViewModel> GetAccounts();
        int GetUserOfNumber();
    }
}
