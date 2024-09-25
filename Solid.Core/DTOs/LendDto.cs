using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class LendDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime date { get; set; }
        public int Count_Book { get; set; }


    }
}
