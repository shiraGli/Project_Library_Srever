using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Servise;
using Solid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
    public class AccountServise: IAccountServise
    {
        private readonly IAccountRepository _accountRepository;
        public AccountServise(IAccountRepository accountRepository)
        {
                _accountRepository = accountRepository; 
        }
        public List<Account> GetAccount()
        {
            return _accountRepository.GetAlllAccount();
        }
        public int AddAccount(Account a)
        {
            return _accountRepository.AddAccount(a);
        }
        public Account GetIdAccount(int id)
        {
            return _accountRepository.GetIdAccount(id);
        }
        public void DeleteAccount(int id)
        {
            _accountRepository.deleteAccount(id);
        }
        public Account updateAccount(int id, Boolean flag)
        {
            return _accountRepository.updateAccount(id,flag);
        }

    }

}
