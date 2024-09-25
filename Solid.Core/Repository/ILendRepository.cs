using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface ILendRepository
    {
        public List<Lend> GetAlllLend();
        public void addLend(Lend lend);
        public Lend GetIdLend(int id);
        public void DeleteLend(int id);
        public Lend UpdateLend(int id, int counter);
    }
}
