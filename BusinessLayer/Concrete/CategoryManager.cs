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
        // ICategoryService'ı implemente ettik. 
        // Verilerin süzgeçten geçirildiği katman bu Manager sınıflarıdır!!!
        // Repository, IRepository'de CRUD işlemlerini implemente eden sınıftı.
       
        ICategoryDal _categoryDal; // Field tanımlama

        public CategoryManager(ICategoryDal categoryDal)
        {
            // Generate Constructor bu metottur.
            _categoryDal = categoryDal;
        }

        public void changeCategoryStatusToFalse(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            Category category = _categoryDal.find(x => x.id == id);
            category.status = false;
            _categoryDal.update(category);
        }

        public void changeCategoryStatusToTrue(int id)
        {
            // Admin panelinde kategorileri pasif yapma
            Category category = _categoryDal.find(x => x.id == id);
            category.status = true;
            _categoryDal.update(category);
        }

        public List<Category> getList()
        {
            return _categoryDal.list();
        }

        public Category getById(int id)
        {
            return _categoryDal.getById(id);
        }

        public void TAdd(Category t)
        {
            _categoryDal.insert(t);
        }

        public void updateT(Category t)
        {
            _categoryDal.update(t);
        }

        public void deleteT(Category t)
        {
            _categoryDal.delete(t);
        }
    }
}
