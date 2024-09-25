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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Customer> GetAlllCustomer()
        {
            return _context.customers.ToList();
        }
        public Customer GetCustomer(int id)
        {
            var cust = _context.customer.Find(id);
            return cust;
        }
        public bool GetCustomerPassword(string password, string name)
        {
            var cust = _context.customer.Where(a => a.Password.Equals(password) && a.Name.Equals(name));
            if (cust != null)
                return true;
            return false;
        }
        public void AddCustomer(Customer c)
        {
            _context.customers.Add(c);
            _context.SaveChanges();
        }
        public Customer Update(Customer c)
        {
            var customerChange = GetCustomer(c.Id);
            customerChange.Name = c.Name;
            customerChange.Email = c.Email;
            //customerChange.accounts=c.accounts;
            customerChange.Sum = c.Sum;
            //customerChange.Count_Book = c.Count_Book;
            customerChange.Max = c.Max;
            _context.SaveChanges();
            return customerChange;
        }
        public void Delete(int id)
        {
            var customer = GetCustomer(id);
            _context.customer.Remove(customer);
            _context.SaveChanges();
        }
        public List<Book> GetBooks()
        {
            return _context.book.ToList();
        }
        //public List<Account> GetIdAccount(int idC)
        //{
        //    var c = _context.account.Where(o=>o.CustomerId==idC).ToList();
        //    return c;
        //}
        public List<Lend> GetIdBookOnLoan(int idC)
        {
            var c = _context.lend.Where(o => o.CustomerId == idC).ToList();
            return c;
        }
        public bool CheckBook(int idC)
        {
            var c = GetCustomer(idC);
            if (c.Max > c.Sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Customer GetNameAndPassord(string name, string password)
        {
            return _context.customer.FirstOrDefault(u => u.Name == name && u.Password == password);
        }

    }
}