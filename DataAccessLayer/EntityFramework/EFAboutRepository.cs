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
    public class EFAboutRepository : GenericRepository<Category>, IAboutDal
    {
        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public void Insert(About t)
        {
            throw new NotImplementedException();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }

        About IGenericDal<About>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<About> IGenericDal<About>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
