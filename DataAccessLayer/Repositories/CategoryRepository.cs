using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Respositories
{
    public class CategoryRepository : ICategoryDal
    {

        Context c = new Context();

        public void Insert(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void Delete(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int Id)
        {
            return c.Categories.Find(Id);
        }

        public List<Category> ListAll()
        {
            return c.Categories.ToList();
        }

        public void Update(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}