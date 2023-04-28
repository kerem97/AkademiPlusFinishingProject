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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public List<Blog> TGetBlogByCategory()
        {
            return _blogDal.GetListbyCategory();
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetByID(id);
        }



        public void TInsert(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> TGetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BLogID == id);
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetListAll();
        }

       
    }
}
