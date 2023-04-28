using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeaturedProductManager : IFeaturedProductService
    {
        private readonly IFeaturedProductDal _featuredProductDal;

        public FeaturedProductManager(IFeaturedProductDal featuredProductDal)
        {
            _featuredProductDal = featuredProductDal;
        }

        public void TDelete(FeaturedProduct t)
        {
            _featuredProductDal.Delete(t);
        }

        public FeaturedProduct TGetByID(int id)
        {
            return _featuredProductDal.GetByID(id);
        }

        public List<FeaturedProduct> TGetList()
        {
            return _featuredProductDal.GetListAll();
        }

     
        public void TInsert(FeaturedProduct t)
        {
            _featuredProductDal.Insert(t);
        }

        public void TUpdate(FeaturedProduct t)
        {
            _featuredProductDal.Update(t);
        }
    }
}
