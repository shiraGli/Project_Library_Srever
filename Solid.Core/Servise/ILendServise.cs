using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface ILendServise
    {
        public List<Lend> GetLend();
        public void addLend(Lend l);
        public Lend GetIdLend(int id);
        public void DeleteLend(int id);
        public Lend updatelend(int id, int counter);
    }
}
