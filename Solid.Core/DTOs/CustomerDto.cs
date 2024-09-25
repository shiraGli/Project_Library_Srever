using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Sum { get; set; }
        public string password { get; set; }
        
        public int Max { get; set; }
       // public int AccountId { get; set; }
        public List<Account> accounts { get; set; }
    }
}
