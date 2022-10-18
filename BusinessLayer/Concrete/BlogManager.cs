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
    public class BlogManager:IBlogService
    {
        IBlogDal _blogDal;
        // Manager sınıfları sadece metotların çağırıldığı sınıflar olursa SOLID'e uygun olur.
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        /*
        public List<Blog> blogById(int id)
        {
            // id'ye göre blogları ilgili yere getirir. İstenilen yer yani bu metot nerede çağırıldıysa!
            return repoBlog.list().Where(x=>x.id==id).ToList();
            // Bu return ifadesinde EntityFramework'ün bir metodu olan ToList() kullandık ama bu SOLID prensiplerine aykırıdır. Çünkü BusinessLayer'ın ne gereği var gibi bir durum ortaya çıkıyor.
            // Çünkü katmanlı mimaride biz CRUD işlemlerini DataAccessLayer'da ilgili sınıfta tanımlıyoruz. O yüzden aslında bu kullanım çalışır, sonuç döndürür ancak SOLID'e aykırıdır.
             
        }
        Expression Delegate ifadesi yazıldıktan sonra bu metodu kullanmaya gerek yoktur.
        */

        public List<Blog> getBlogById(int id)
        {
            // Expression Delegate ile yazılabilen Generic ve dinamik yapıya bu kullanım örnektir.
            return _blogDal.list(x => x.id == id); // Yani burada mesela EntityFramework'ün ToList() metodunu kullanmaya gerek kalmadı ve SOLID'e uygun bir mimari inşa ettik.
        }

        public List<Blog> getBlogByAuthor(int id)
        {
            // Expression Delegate ile yazılabilen Generic ve dinamik yapıya bu kullanım örnektir.
            return _blogDal.list(x => x.authorId == id); // Yani burada mesela EntityFramework'ün ToList() metodunu kullanmaya gerek kalmadı ve SOLID'e uygun bir mimari inşa ettik.
        }

        public List<Blog> getBlogByCategory(int id)
        {
            // Expression Delegate ile yazılabilen Generic ve dinamik yapıya bu kullanım örnektir.
            return _blogDal.list(x => x.categoryId == id); // Yani burada mesela EntityFramework'ün ToList() metodunu kullanmaya gerek kalmadı ve SOLID'e uygun bir mimari inşa ettik.
        }

        public List<Blog> getList()
        {
            return _blogDal.list();
        }

        public Blog getById(int id)
        {
            return _blogDal.getById(id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.insert(t);
        }

        public void updateT(Blog t)
        {
            _blogDal.update(t);
        }

        public void deleteT(Blog t)
        {
            _blogDal.delete(t);
        }
    }
}
