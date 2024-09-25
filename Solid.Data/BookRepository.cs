using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class BookRepository: IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Book> GetAlllBook()
        {
            return _context.book.ToList();
        }
        public Book GetIdBook(int id)
        {
            var book=_context.book.Find(id);
            return book;
        }
        public void AddBook(Book b)
        {
            _context.book.Add(b);
            _context.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            var book = GetIdBook(id);
            _context.book.Remove(book);
            _context.SaveChanges();
        }
        public Book UpdateBook(int id,int count)
        {
            var bookChange = GetIdBook(id);
           
            bookChange.Count=count;
          
            _context.book.Update(bookChange);
            _context.SaveChanges();
            return bookChange;
        }

    }
}
