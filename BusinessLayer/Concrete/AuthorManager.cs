using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoAuthor = new Repository<Author>();

        public List<Author> getAll()
        {
            // Sitedeki bütün yazarları liste halinde döndüren metot budur.
            return repoAuthor.list(); // Repository'deki metotları çağırabiliyoruz.
        }

        public void addNewAuthorBL(Author p)
        {
            // Bu metot ile yeni yazar ekleme işlemi yapılabilmektedir.
            // if bloğunda parametreden gönderilen değerlerin geçerliliğini kontrol ediyoruz.
            //if(p.name=="" || p.aboutShort=="" || p.job == "")
            //{
            //    return -1;
            //}
            repoAuthor.insert(p);
        }

        public Author findAuthor(int id)
        {
            // Yazarı id değerine göre edit sayfasına taşıma
            return repoAuthor.find(x => x.id == id);
        }

        public void editAuthor(Author p)
        {
            Author author = repoAuthor.find(x => x.id == p.id);
            author.name = p.name;
            author.image = p.image;
            author.job = p.job;
            author.password = p.password;
            author.mail = p.mail;
            author.phoneNumber = p.phoneNumber;
            author.aboutShort = p.aboutShort;
            author.about = p.about;
            repoAuthor.update(author);
        }
    }
}
