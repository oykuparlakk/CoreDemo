using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlog(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            throw new NotImplementedException();
        }

        public void RemoveBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
