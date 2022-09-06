using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager:IAuthorService
    {
        IAuthorDal authorDal;

        Repository<Author> repoAuthor = new Repository<Author>();

        public AuthorManager(IAuthorDal authorDal)
        {
            this.authorDal = authorDal;
        }

        public List<Author> getList()
        {
            return authorDal.list();
        }

        public void authorAdd(Author author)
        {
            authorDal.insert(author);
        }

        public Author getById(int id)
        {
            return authorDal.getById(id);   
        }

        public void updateAuthor(Author author)
        {
             authorDal.update(author);
        }

        public void deleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
