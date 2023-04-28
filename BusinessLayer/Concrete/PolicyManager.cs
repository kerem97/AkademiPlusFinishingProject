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
    public class PolicyManager : IPolicyService
    {
        private readonly IPolicyDal _policyDal;

        public PolicyManager(IPolicyDal policyDal)
        {
            _policyDal = policyDal;
        }

        public void TDelete(Policy t)
        {
            _policyDal.Delete(t);
        }

        public Policy TGetByID(int id)
        {
            return _policyDal.GetByID(id);
        }

        public List<Policy> TGetListAll()
        {
            return _policyDal.GetListAll();
        }

        public void TInsert(Policy t)
        {
            _policyDal.Insert(t);
        }

        public void TUpdate(Policy t)
        {
            _policyDal.Update(t);
        }
    }
}
