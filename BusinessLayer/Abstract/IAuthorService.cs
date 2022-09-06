using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAuthorService
    {
        List<Author> getList();
        void authorAdd(Author author);
        Author getById(int id);
        void updateAuthor(Author author);
        void deleteAuthor(Author author);
    }
}
