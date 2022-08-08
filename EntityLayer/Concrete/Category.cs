using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Projeye yeni bir sınıf eklenirken öncelikle EntityLayer.Concrete, ardından DataAccessLayer.Concrete.Context içerisine tanımlama yapılır ve ardından migration işlemine geçilir. 
// Ardından BusinessLayer katmanında manager sınıfı ile yeni eklenen özelliklerin tanımı ve kısıtlaması belirlenir.
// Ardından Controller'da bu özellik veya nesneler için controller tanımlaması ve user interface oluşturulur ve özellik aktif olarak kullanıcıya sunulmaya hazır hale gelir.
namespace EntityLayer.Concrete
{
    // public erişim belirleyiciye sahip olması diğer sınıflardan erişim sağlayabilmek içindir.
    public class Category
    {
        // class isimleri ilk harf büyük tanımlanır.
        // property ya da diğer adıyla değişkenler camelCase yaklaşımı ile tanımlanır.

        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string name  { get; set; } // Burada kısıtlama uygulamaz isek veri tabanına nvarchar(max) olarak tanımlanır.

        [StringLength(500)]
        public string description { get; set; }

        // Bir kategoride birden fazla blog olabilir. Bu yüzden bire-çok ilişki tanımlaması yapılır.
        public ICollection<Blog> blogs { get; set; }
    }
}
