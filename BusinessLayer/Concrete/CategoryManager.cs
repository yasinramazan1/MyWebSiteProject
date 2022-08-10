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

        public int categoryAddBL(Category p)
        {
            // Admin panelinde yeni kategori ekleme 
            if (p.name == "" || p.description == "" || p.name.Length <= 3)
            {
                return -1;
            }
            return repoCategory.insert(p);
        }

        public Category findCategory(int id)
        {
            // Kategoriyi id değerine göre edit sayfasına taşıma
            return repoCategory.find(x => x.id == id);
        }

        public int editCategory(Category p)
        {
            Category category = repoCategory.find(x => x.id == p.id);
            if (p.name == "" || p.name.Length <= 4 || p.description.Length <= 10)
            {
                return -1;
            }
            category.name = p.name;
            category.description = p.description;
            return repoCategory.update(category);
        }

        public int changeCategoryStatusToFalse(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            Category category = repoCategory.find(x => x.id == id);
            category.status = false;
            return repoCategory.update(category);
        }

        public int changeCategoryStatusToTrue(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            Category category = repoCategory.find(x => x.id == id);
            category.status = true;
            return repoCategory.update(category);
        }
    }
}
