using DataAccessLayer.Concrete;
using EntityLayer.Concrete; // List<Category> tanımında Category nesnesini çağırabilmek için gerekli kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        // Verilerin süzgeçten geçirildiği katman bu Manager sınıflarıdır!!!
        // Repository, IRepository'de CRUD işlemlerini implemente eden sınıftı.
        Repository<Category> repoCategory = new Repository<Category>(); // Burada veri listeleme işlemini Repository sınıfına bağlı olarak gerçekleştiriyoruz.
        public List<Category> getAll()
        {
            return repoCategory.list(); // Repository'deki metotları çağırabiliyoruz.
        }
    }
}
