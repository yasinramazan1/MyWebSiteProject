using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repoUser = new Repository<Author>();
        Repository<Blog> repoUserBlog = new Repository<Blog>();

        public List<Author> getAuthorByMail(string p)
        {
            // Gönderilen p parametresi aslında bizim gönderdiğimiz mail adresidir.
            // Mail adresine göre ilgili yazarın bilgilerini getiren metot budur.
            // Expression Delegate ile yazılabilen Generic ve dinamik yapıya bu kullanım örnektir.
            return repoUser.list(x => x.mail == p); // Yani burada mesela EntityFramework'ün ToList() metodunu kullanmaya gerek kalmadı ve SOLID'e uygun bir mimari inşa ettik.
        }

        public List<Blog> getBlogsByAuthor(int id)
        {
            // Yazara göre blogları getiren metot burasıdır.
            return repoUserBlog.list(x => x.authorId == id);
        }
    }
}
