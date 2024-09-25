using Solid.Core.Entities;
using Solid.Core.Repository;
using Solid.Core.Servise;
using Solid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
    public class LendServise: ILendServise
    {
        private readonly ILendRepository _lendRepository;
        public LendServise(ILendRepository lendRepository)
        {
            _lendRepository = lendRepository;
        }
        public List<Lend> GetLend()
        {
            return _lendRepository.GetAlllLend();
        }
        public void addLend(Lend l)
        {
            _lendRepository.addLend(l);   
        }
        public Lend GetIdLend(int id)
        {
           return _lendRepository.GetIdLend(id);
        }
        public void DeleteLend(int id) { 

               _lendRepository.DeleteLend(id); 
        }
        public Lend updatelend(int id,int counter)
        {
            return _lendRepository.UpdateLend(id, counter);
        }
    }
}
