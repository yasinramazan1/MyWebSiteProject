using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions; // Expression Delegate ifadelerinin kullanımı için gerekli olan C# kütüphanesi
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // IRepository içerisine bir EntityLayer katmanından değer göndermek için "<T>" şeklinde tanımlama yapılır.
    // Bu gönderilen T nesnesine göre IRepository'de tanımlı CRUD işlemleri veya tanımlı hangi işlemler var ise yapılır.

    public interface IRepository<T> 
    {
        List<T> list(); 
        // Listeleme metodu

        // Ekleme işleminin int olması, C#'ta ExecuteNoneQuery() metodunun etkilenen kayıt sayısı olarak geriye bir int türünde değer döndürmesindendir.
        // T nesnesinden türetilen parametreleri eklemek için aşağıdaki gibi parametre girilir.
        int insert(T p);

        int update(T p);

        int delete(T p);

        T getById(int id); // Güncelleme işlemlerinde kullanılan metottur!
        // id'yi getirme metodu, yani bir örneğin kategorinin bloğuna erişmek için öncelikle o kategorinin id'sini getirmek için tanımlanmıştır.
        // Parametre olarak girilen id dışarıdan girilen id'dir.

        /*
        // BlogManager sınıfında EntityFramework'ün ToList() metoduna yönelik yapılan açıklamanın SOLID'e uygun olarak katmanlı mimaride uygulanışı aşağıdaki metot ile sağlanmıştır.
        List<T> listWhere(int id);
        Bu ifadeler expression metodu ile kullanımına gerek kalmamıştır. Yani aslında bu ifadelerin yazımına gerek yoktur, bunun yerine expression ifadeleri kullanıyoruz.
        */

        List<T> list(Expression<Func<T, bool>> filter); // istediğimiz herhangi bir şarta göre search işlemi yapabileceğimiz Expression Delegate ifadesi bu şekildedir.

        T find(Expression<Func<T, bool>> where); // İstediğimiz herhangi bir şarta göre o değeri bulma metodu budur.
    }
}
