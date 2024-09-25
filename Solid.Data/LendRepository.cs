using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class LendRepository: ILendRepository
    {
        CustomerRepository CustomerRepository;
        Lend l;
        private readonly DataContext _context;
        public LendRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Lend> GetAlllLend()
        {
            return _context.lend.ToList();
        }
        public void addLend(Lend l)
        {
            _context.lend.Add(l);
            _context.SaveChanges();
        }
        public Lend UpdateLend(int id, int counter)
        {
            var lendChange = GetIdLend(id);

            lendChange.Count_Book = counter;

            _context.lend.Update(lendChange);
            _context.SaveChanges();
            return lendChange;
        }



        //public void addLend(Customer c,DateTime date)
        //{
        //    if (CustomerRepository.CheckBook(c.Id))
        //    {
        //        l.date = date;
        //        l.CustomerId = c.Id;
        //        _context.lend.Add(l);
        //        c.Sum++;
        //        CustomerRepository.Update(c);
        //        _context.SaveChanges();
        //    }

        //}
        public Lend GetIdLend(int id)
        {
            var lend = _context.lend.Find(id);
            return lend;
        }
        public void DeleteLend(int id)
        {
            var lend = GetIdLend(id);
            _context.lend.Remove(lend);
            _context.SaveChanges();
        }

    }
}
