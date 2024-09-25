using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAlllCustomer();

        public bool GetCustomerPassword(string password, string name);
        public Customer GetCustomer(int id);

        public void AddCustomer(Customer c);

        public Customer Update(Customer c);

        public void Delete(int id);

        public List<Book> GetBooks();

        //public List<Account> GetIdAccount(int idC);
        public List<Lend> GetIdBookOnLoan(int idC);

        public bool CheckBook(int idC);
        public Customer GetNameAndPassord(string name, string password);
   
        }
    }  

