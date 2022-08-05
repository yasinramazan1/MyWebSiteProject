using System;
using System.Collections.Generic;
using System.Linq;
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

        T getById(int id); 
        // id'yi getirme metodu, yani bir örneğin kategorinin bloğuna erişmek için öncelikle o kategorinin id'sini getirmek için tanımlanmıştır.
        // Parametre olarak girilen id dışarıdan girilen id'dir.

    }
}
