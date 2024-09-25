using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface IAccountServise
    {
        public List<Account> GetAccount();
        public int AddAccount(Account a);
    
        public Account GetIdAccount(int id);

        public Account updateAccount(int id, Boolean flag);
        public void DeleteAccount(int id);

    }
}
