using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void RemoveBlog(Blog blog);
        void UpdateBlog(Blog blog);
        List<Blog> GetList();
        List<Blog> GetBlogListWithCategory();
        Blog GetById(int id);
    }
}
