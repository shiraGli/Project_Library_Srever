using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface ICustomerServise
    {
        public List<Customer> GetCustomer();
        public void AddCustomer(Customer c);
        public void DeleteCustomer(int id);
        public Customer GetIdCustomer(int id);
        public bool GetCustomerPassword(string password, string name);
        public Customer GetNameAndPassord(string name, string password);
    }
}