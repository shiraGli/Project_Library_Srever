using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class AccountRepository: IAccountRepository
    {
        private readonly DataContext _context;
        public AccountRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Account> GetAlllAccount()
        {
            return _context.account.ToList();
        }
        public Account GetIdAccount(int id)
        {
            var account = _context.account.Find(id);
            return account;
        }
        public List<Account> GetNonPay()
        {
            var c=_context.account.Where(o => o.pay == false).ToList();
            return c.ToList();
        }
        public int AddAccount(Account a)
        {
            _context.account.Add(a);
            _context.SaveChanges();
            return a.Id;
        }
        public void deleteAccount(int id)
        {
            var acount = GetIdAccount(id);
            _context.account.Remove(acount);
            _context.SaveChanges();
        }
        public Account updateAccount(int id, Boolean flag)
        {
            var accountChange = GetIdAccount(id);
            accountChange.pay = flag;

            _context.account.Update(accountChange);
            _context.SaveChanges();
            return accountChange;
        }
    }
    
}
