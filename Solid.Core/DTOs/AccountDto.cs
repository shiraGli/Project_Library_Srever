using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class AccountDto
    {
        public int Id { get; set; }

        public Boolean pay { get; set; }

        public int Month { get; set; }
        public int CustomerId { get; set; }
    }
}
