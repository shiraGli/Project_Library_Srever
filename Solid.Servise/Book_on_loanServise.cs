using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
    public class Book_on_loanServise: IBook_on_loanServise
    {
        private readonly IBook_on_loanRepository _book_on_loanRepository;
        public Book_on_loanServise(IBook_on_loanRepository book_on_loanRepository)
        {
            _book_on_loanRepository = book_on_loanRepository;
        }
        public List<Books_on_loan> GetBooks_on_loan()
        {
            return _book_on_loanRepository.GetAlllBooks_on_loan();
        }
        
        //public void DeleteBookOnLoan(int id)
        //{
        //    _book_on_loanRepository.DeleteBookOnLoan(id);
        //}
        public void AddBookOnLoan(Books_on_loan b)
        {
            _book_on_loanRepository.AddBookOnLoan(b);
        }
        public Books_on_loan GetIdBoookOnLoan(int id)
        {
            return _book_on_loanRepository.GetIdBoookOnLoan(id);
        }
        public void DeleteBookOnLoan(int id)
        {
            var bookOnLoanArr = _book_on_loanRepository.GetAlllBooks_on_loan();
            var book=bookOnLoanArr.Find(a => a.BookId == id);
            _book_on_loanRepository.DeleteBookOnLoan(book.Id);
        }
    }
}
