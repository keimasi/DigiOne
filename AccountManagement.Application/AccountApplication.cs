using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framwork.Application;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.Account;
using AccountManagement.Domain.Role;

namespace AccountManagement.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAccountRepository _accountRepository;
        private readonly IAuthenticationHelper _authenticationHelper;
        private readonly IRoleRepository _roleRepository;

        public AccountApplication(IAccountRepository accountRepository, IPasswordHasher passwordHasher, IAuthenticationHelper authenticationHelper, IRoleRepository roleRepository)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
            _authenticationHelper = authenticationHelper;
            _roleRepository = roleRepository;
        }

        public OperationResult Create(CreateAccount command)
        {
            var operation = new OperationResult();

            if (_accountRepository.Exists(x => x.UserName == command.UserName || x.Mobile == command.Mobile))
                return operation.Failed("کاربری با این مشخصات ثبت نام کرده است");

            var password = _passwordHasher.Hash(command.Password);

            var account = new AccountEntity(command.FullName, command.UserName, password, command.Mobile,
                command.RoleId);

            _accountRepository.Create(account);
            _accountRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditAccount command)
        {
            var operation = new OperationResult();

            var account = _accountRepository.Get(command.Id);
            if (account == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_accountRepository.Exists(x => (x.UserName == command.UserName || x.Mobile == command.Mobile) && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            account.Edit(command.FullName, command.UserName, command.Mobile, command.RoleId);
            _accountRepository.Save();
            return operation.Success();
        }

        public OperationResult ChangePassword(ChangePassword command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);

            if (account == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (command.Password != command.RePassword)
                return operation.Failed(ApplicationMessage.InvalidPassword);

            var password = _passwordHasher.Hash(command.Password);
            account.ChangePassword(password);

            _accountRepository.Save();
            return operation.Success();
        }

        public OperationResult Login(Login command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.GetBy(command.Username);

            if (account == null)
                return operation.Failed(ApplicationMessage.UserNotFound);

            var password = _passwordHasher.Check(account.Password, command.Password);
            if (!password.Verified)
                return operation.Failed(ApplicationMessage.UserNotFound);

            var permissions = _roleRepository.Get(account.RoleId).Permissions.Select(x => x.Code).ToList();

            var authViewModel = new AuthenticationViewModel(account.Id, account.RoleId, account.FullName, account.UserName,permissions);
            _authenticationHelper.Signin(authViewModel);

            return operation.Success();
        }

        public void Logout()
        {
            _authenticationHelper.SignOut();
        }

        public EditAccount GetDetails(int id)
        {
            return _accountRepository.GetDetails(id);
        }

        public List<AccountViewModel> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public int GetUserOfNumber()
        {
            return _accountRepository.GetUserOfNumber();
        }
    }
}
