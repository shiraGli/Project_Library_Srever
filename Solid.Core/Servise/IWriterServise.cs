using Solid.Core.Entities;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface IWriterServise
    {
        public List<Writer> GetWriter();
        public void AddWriter(Writer w);
        public Writer GetIdWriter(int id);
        public void DeleteWriter(int id);

    }
}
