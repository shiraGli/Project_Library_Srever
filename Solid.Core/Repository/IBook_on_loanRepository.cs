using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface IBook_on_loanRepository
    {
        public List<Books_on_loan> GetAlllBooks_on_loan();
        public void DeleteBookOnLoan(int id);
        public void AddBookOnLoan(Books_on_loan b);
        public Books_on_loan GetIdBoookOnLoan(int id);


    }
}
