using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class WriterDto
    {
        public int id { get; set; }
        public string name { get; set; }
         public int AccountId { get; set; }
        public List<Book> books { get; set; }
    }
}
