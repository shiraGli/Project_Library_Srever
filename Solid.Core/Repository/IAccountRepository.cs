using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface IAccountRepository
    {
        public List<Account> GetAlllAccount();
        public int AddAccount(Account a);
        public void deleteAccount(int id);
        public Account GetIdAccount(int id);
        public Account updateAccount(int id, Boolean flag);
    }
}
