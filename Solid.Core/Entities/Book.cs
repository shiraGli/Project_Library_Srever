using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Count { get; set; }
        public  Writer Writer { get; set; }
        public int WriterId { get; set; }   


    }
}
