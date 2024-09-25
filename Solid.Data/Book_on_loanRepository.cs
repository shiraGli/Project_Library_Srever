using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class Book_on_loanRepository: IBook_on_loanRepository
    {
        private readonly DataContext _context;
        public Book_on_loanRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Books_on_loan> GetAlllBooks_on_loan()
        {
            return _context.books_on_loan.ToList();
        }
        public Books_on_loan GetIdBoookOnLoan(int id)
        {
           var books_on_loan = _context.books_on_loan.Find(id);
            return books_on_loan;
        }
        public void AddBookOnLoan(Books_on_loan b)
        {
            _context.books_on_loan.Add(b);
            _context.SaveChanges();
        }
        public void DeleteBookOnLoan(int id)
        {
           
            var books_on_loan=GetIdBoookOnLoan(id);
            _context.books_on_loan.Remove(books_on_loan);
            _context.SaveChanges();
        }
    }
}
