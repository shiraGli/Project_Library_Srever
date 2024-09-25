using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Writer
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Book> books { get; set; }  

    }
}
