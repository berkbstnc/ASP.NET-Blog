using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        Category IGenericDal<Category>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Category> IGenericDal<Category>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
