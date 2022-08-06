using EntityLayer.Concrete; // DbSet içinde sınıfları çağırmak için EntityLayer.Concrete kütüphanesini dahil etmemiz gerekir.
using System;
using System.Collections.Generic;
using System.Data.Entity; // DbContext sınıfı için gerekli kütüphane 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // Context sınıfı Code First ile veri tabanı üzerinde kullanılabilmek için DbContext sınıfını miras almalıdır.
    public class Context:DbContext
    {
        // Veri tabanına yansıtmak için birden fazla yöntem vardır ve biz burada "migration" yöntemini kullanıyoruz.
        // Context sınıfı EntityLayer katmanında tanımalanan sınıfları veritabanına yansıtmak için gerekli olan köprü işlevini görmektedir.
        public DbSet<About> ABOUTS { get; set; }
        // Burada pluralize olan isimlendirmeler, veri tabanındaki tablo isimlerine karşılık gelmektedir.
        // Veri tabanında tablo isimlendirmeleri lowerCamelCase ya da tamamı büyük harf ile tanımlanmalıdır.
        // Büyük harf ile tanımlanan isimlendirmelerde iki ve daha fazla kelimeden oluşan isimlendirmeler "_" ile ayrılır.
        
        public DbSet<Admin> ADMINS { get; set; }
        
        public DbSet<Author> AUTHORS { get; set; }
        
        public DbSet<Blog> BLOGS { get; set; }
       
        public DbSet<Category> CATEGORIES { get; set; }
        
        public DbSet<Comment> COMMENTS { get; set; }
        
        public DbSet<Contact> CONTACTS { get; set; }

        // "migration" işleminin yapılabilmesi için Package Manager Console'da DataAccessLayer katmanının seçili olması gerekir çünkü Context sınıfı bu katmanda tanımlıdır.
        // Context sınıfı hangi katmanda ise o katmandan migration işlemi yapılır.
        // "migration" işlemi için öncelikle "enable-migrations"; ardından "update-database" komutu çalıştırılır.

        public DbSet<SubscribeMail> SUBSCRIBEMAILS { get; set; }
    }
}
