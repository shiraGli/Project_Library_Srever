using Microsoft.EntityFrameworkCore;
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

    public class CustomerServise : ICustomerServise
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerServise(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetCustomer()
        {
            return _customerRepository.GetAlllCustomer();
        }
        public void AddCustomer(Customer c)
        {
            _customerRepository.AddCustomer(c);
        }
        public bool GetCustomerPassword(string password, string name)
        {
            return _customerRepository.GetCustomerPassword(password, name);
        }
        public void DeleteCustomer(int id)
        {
            _customerRepository.Delete(id);
        }
        public Customer GetIdCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }
        public Customer GetNameAndPassord(string name, string password)
        {
            return _customerRepository.GetNameAndPassord(name, password);
        }
        public bool checkTz(string Tz)
        {
            int cnt = 0, x, sum = 0;
            for (int i = 0; i < Tz.Length; i++)
            {
                if (Tz[i] > 49 || Tz[i] > 57)
                {
                    return false;
                }
                cnt++;
            }
            if (cnt >= 5 && cnt <= 9)
            {
                for (int i = 0; i < Tz.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        x = (Convert.ToInt32(Tz[i])) * 2;
                        if (x > 9)
                            x -= 9;
                        sum += x;
                    }
                    sum += Convert.ToInt32(Tz[i]);
                }
                if (sum % 10 == 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
    
}