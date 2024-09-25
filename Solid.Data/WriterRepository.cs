using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class WriterRepository:IWriterRepository
    {
        private readonly DataContext _context;
        public WriterRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Writer> GetAlllWriter()
        {
            return _context.writer.ToList();
        }
        public void AddWriter(Writer w)
        {
            _context.Add(w);
            _context.SaveChanges();
        } 
        public Writer GetIdWriter(int id)
        {
            var writer = _context.writer.Find(id);
            return writer;
        }
        public void DeleteWriter(int id)
        {
            var writer = GetIdWriter(id);
            _context.writer.Remove(writer);
            _context.SaveChanges();
        }
    }
}
