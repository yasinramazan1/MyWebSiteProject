using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Bir kategoride birden fazla blog olabilir. Bu yüzden bire-çok ilişki tanımlaması yapılır.
        public ICollection<Blog> blogs { get; set; }
    }
}
