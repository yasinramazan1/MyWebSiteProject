using DataAccessLayer.Abstract; // IRepository interface'ini çağırabilmek için gerekli olan kütüphane
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity; // DbSet sınıfı için gerekli kütüphane
using System.Linq;
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

        public int delete(T p)
        {
            _object.Remove(p);  
            return context.SaveChanges();
        }

        public T getById(int id)
        {
            return _object.Find(id);
        }

        public int insert(T p)
        {
            _object.Add(p);
            return context.SaveChanges();
        }

        public List<T> list()
        {
            return _object.ToList();
        }

        public int update(T p)
        {
            return context.SaveChanges();   
        }
    }
}
