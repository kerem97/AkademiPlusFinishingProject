using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewArrivalManager : INewArrivalService
    {
        private readonly INewArrivalDal _newArrivalDal;

        public NewArrivalManager(INewArrivalDal newArrivalDal)
        {
            _newArrivalDal = newArrivalDal;
        }

        public void TDelete(NewArrival t)
        {
            _newArrivalDal.Delete(t);
        }

        public NewArrival TGetByID(int id)
        {
            return _newArrivalDal.GetByID(id);
        }

        public List<NewArrival> TGetListAll()
        {
            return _newArrivalDal.GetListAll();
        }

        public void TInsert(NewArrival t)
        {
            _newArrivalDal.Insert(t);
        }

        public void TUpdate(NewArrival t)
        {
            _newArrivalDal.Update(t);
        }
    }
}
