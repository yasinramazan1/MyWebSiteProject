using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete; // List<Category> tanımında Category nesnesini çağırabilmek için gerekli kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager: ICategoryService
    {
        // Verilerin süzgeçten geçirildiği katman bu Manager sınıflarıdır!!!
        // Repository, IRepository'de CRUD işlemlerini implemente eden sınıftı.
        Repository<Category> repoCategory = new Repository<Category>(); // Burada veri listeleme işlemini Repository sınıfına bağlı olarak gerçekleştiriyoruz.

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> getAll()
        {
            return repoCategory.list(); // Repository'deki metotları çağırabiliyoruz.
        }

        public void changeCategoryStatusToFalse(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            Category category = repoCategory.find(x => x.id == id);
            category.status = false;
            repoCategory.update(category);
        }

        public void changeCategoryStatusToTrue(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            Category category = repoCategory.find(x => x.id == id);
            category.status = true;
            repoCategory.update(category);
        }

        public List<Category> getList()
        {
            return _categoryDal.list();
        }

        public void categoryAdd(Category category)
        {
            _categoryDal.insert(category);
        }

        public Category getById(int id)
        {
            return _categoryDal.getById(id);
        }

        public void updateCategory(Category category)
        {
            _categoryDal.update(category);
        }

        public void deleteCategory(Category category)
        {
            _categoryDal.delete(category);
        }
    }
}
