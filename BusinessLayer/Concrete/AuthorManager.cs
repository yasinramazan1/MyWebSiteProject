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
        IAuthorDal _authorDal;

        Repository<Author> repoAuthor = new Repository<Author>();

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> getList()
        {
            // Tüm yazarların listesini getirme
            return _authorDal.list();
        }

        public Author getById(int id)
        {
            return _authorDal.getById(id);   
        }

        public void deleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Author t)
        {
            _authorDal.insert(t);
        }

        public void updateT(Author t)
        {
            _authorDal.update(t);
        }

        public void deleteT(Author t)
        {
            throw new NotImplementedException();
        }
    }
}
