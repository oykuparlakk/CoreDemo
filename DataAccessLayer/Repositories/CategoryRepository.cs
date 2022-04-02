using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context _context = new Context();
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Find(id);   
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return _context.Categories.ToList();
        }

        public void RemoveCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
        }
    }
}
