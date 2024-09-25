using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface IWriterRepository
    {
        public List<Writer> GetAlllWriter();
        public void AddWriter(Writer w);
        public Writer GetIdWriter(int id);
        public void DeleteWriter(int id);

    }
}
