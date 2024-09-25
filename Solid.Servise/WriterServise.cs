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
    public class WriterServise: IWriterServise
    {
        private readonly IWriterRepository _writerRepository ;
        public WriterServise(IWriterRepository writerRepository)
        {
            _writerRepository = writerRepository;
        }
        public List<Writer> GetWriter()
        {
            return _writerRepository.GetAlllWriter();
        }
        public void AddWriter(Writer w)
        {
            _writerRepository.AddWriter(w);
        }
        public Writer GetIdWriter(int id)
        {
            return _writerRepository.GetIdWriter(id);
        }
        public void DeleteWriter(int id)
        {
            _writerRepository.DeleteWriter(id);
        }

    }
}
