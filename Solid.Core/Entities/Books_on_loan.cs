using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Books_on_loan
    {
       public int Id { get; set; }

        public int BookId { get; set; }
        public Book book { get; set; }
        public Lend Lend { get; set; }
        public int LendId { get; set; }
        
        
        
    }
}
