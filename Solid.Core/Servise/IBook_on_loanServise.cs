using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface IBook_on_loanServise
    {
        public List<Books_on_loan> GetBooks_on_loan();

        public void DeleteBookOnLoan(int id);

        public void AddBookOnLoan(Books_on_loan b);

        public Books_on_loan GetIdBoookOnLoan(int id);
       
    }
}
