using DataAccessLayer.Abstract; // IRepository interface'ini çağırabilmek için gerekli olan kütüphane
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity; // DbSet sınıfı için gerekli kütüphane
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // ASLINDA BURASI GENERIC REPOSITORY'İMİZ OLUYOR! Bu tanımlama ile aslında Abstract klasöründeki her bir sınıfı ayrı ayrı interface yapmaya gerek kalmamış oluyor!!!
    // Repository class'ı, Abstract klasöründe tanımlı olan IRepository interface içerisinde bulunan boş metotların ne iş yapacağının tanımlandığı class'tır.
    public class Repository<T> : IRepository<T> where T : class
    {
        // Bir sınıfa bir interface implemente etmek istersek, bu interface içerisindeki bütün metotları bu sınıf içerisinde implemente etmeli yani "Overriding" yapmalıyız.

        // Sınıflara yani sınıfların türetildiği sınıfa erişim sağlayabilmek için Context sınıfından bir nesne türetilmelidir.
        Context context = new Context();
        DbSet<T> _object; // Bu _object değişkeni bizim dışarıdan göndereceğimiz değerlere karşılık gelecektir. Bu Author, Comment, Contact vb. olabilir.

        // Repository sınıfını Constructor yapmamız gerekir. Bunun için bir constructor metot tanımlanır.
        public Repository()
        {
            _object = context.Set<T>(); // Context üzerinden gönderilen sınıfı _object field'ına atama işlemi
        }

        public void delete(T p)
        {
            var deleteEntity = context.Entry(p);
            deleteEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T getById(int id)
        {
            return _object.Find(id);
        }

        public void insert(T p)
        {
            var addedEntity = context.Entry(p);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public List<T> list()
        {
            return _object.ToList();
        }


        /*
        public List<T> listWhere(int id)
        {
            // Buradaki metot Generic yapıyı korur çünkü burada generic yapıyı korumasaydık her sınıfıa ait soyut sınıflarda bu metodu ayrı ayrı overrid etmemiz gerekirdi. Generic yapı bunu kolaylaştırdığı için önemlidir!
            throw new NotImplementedException();
        }
         Bu ifadeler expression metodu ile kullanımına gerek kalmamıştır. Yani aslında bu ifadelerin yazımına gerek yoktur, bunun yerine expression ifadeleri kullanıyoruz.
        */

        public List<T> list(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void update(T p)
        {
            var updateEntity = context.Entry(p);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public T find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }
    }
}
