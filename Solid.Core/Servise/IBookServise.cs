using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface IBookServise
    {
        public List<Book> GetBook();

        public Book GetIdBook(int id);
        public void AddBook(Book b);

        public void DeleteBook(int id);
        public Book updateBook(int id,int count);

    }
}
