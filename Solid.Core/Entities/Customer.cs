using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }
        public int Sum { get; set; }
       
        public int Max { get; set; }
        public List<Account>accounts { get; set; }  //לא מציג לנו במערך כלום
                                                    //אפילו שיש שם נתונים

    }
}
