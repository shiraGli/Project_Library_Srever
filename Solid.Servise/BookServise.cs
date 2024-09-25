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
    public class BookServise: IBookServise
    {
        private readonly IBookRepository _bookRepository;
        public BookServise(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Book> GetBook()
        {
            return _bookRepository.GetAlllBook();
        }
        public Book GetIdBook(int id)
        {
            return _bookRepository.GetIdBook(id);  
        }
        public void AddBook(Book b)
        {
            _bookRepository.AddBook(b);
        }
        public Book updateBook(int id,int count)
        {
           return _bookRepository.UpdateBook(id,count);
        }
        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }
    }
}
