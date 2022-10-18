using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        // metot imzaları
        List<Blog> getBlogById(int id);
        List<Blog> getBlogByAuthor(int id);
    }
}
