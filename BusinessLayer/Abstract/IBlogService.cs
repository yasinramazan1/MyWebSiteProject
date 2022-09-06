using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> getList();
        void blogAdd(Blog blog);
        Blog getById(int id);
        void updateBlog(Blog blog);
        void deleteBlog(Blog blog);
    }
}
