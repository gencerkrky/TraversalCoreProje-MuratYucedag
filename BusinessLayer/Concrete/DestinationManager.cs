using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager:IDestinationService
    {
        IDestintionDal _destintionDal;

        public DestinationManager(IDestintionDal destintionDal)
        {
            _destintionDal= destintionDal;
        }

        public void TAdd(Destination t)
        {
            _destintionDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destintionDal.Delete(t);
        }

        public Destination TGetByID(int id)
        {
            return _destintionDal.GetByID(id);
        }

        public List<Destination> TGetList()
        {
           return _destintionDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destintionDal.Update(t);
        }
    }
}
