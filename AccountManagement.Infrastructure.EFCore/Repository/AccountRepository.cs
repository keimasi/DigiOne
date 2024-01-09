using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Application;
using _0_Framwork.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.Account;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class AccountRepository : RepositoryBace<int, AccountEntity>, IAccountRepository
    {
        private readonly AccountContext _context;

        public AccountRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public EditAccount GetDetails(int id)
        {
            return _context.Accounts.Select(x => new EditAccount
            {
                Id = x.Id,
                FullName = x.FullName,
                UserName = x.UserName,
                Mobile = x.Mobile,
                RoleId = x.RoleId
            }).FirstOrDefault(x => x.Id == id);
        }

        public AccountEntity GetBy(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.UserName == username);
        }

        public List<AccountViewModel> GetAccounts()
        {
            return _context.Accounts.Include(x=>x.Role).Select(x => new AccountViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                UserName = x.UserName,
                Mobile = x.Mobile,
                RoleName = x.Role.Name,
                CreateDate = x.CreateDate.ToFarsi()
            }).ToList();
        }
    }
}
