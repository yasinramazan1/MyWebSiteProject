using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        // Kategorilerle bloglar arasında; yazarlarla bloglar arasında; bloglarla yorumlar arasında ilişki vardır.
        // Kategoriler tek, bloglar çok; yazarlar tek, bloglar çok; bloglar tek, yorumlar çok ilişki türüdür.

        [Key]
        public int id { get; set; }

        [StringLength(200)]
        public string title { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        public DateTime date { get; set; } // Tarih DateTime sınıfı ile tanımlanır.

        // Blog içeriğine kısıtlama getirmedik çünkü blog içeriği çok uzun olabilir.
        public string content { get; set; }

        public int blogRating { get; set; }

        public int categoryId { get; set; }
        public virtual Category category { get; set; }

        public int authorId { get; set; }
        public virtual Author author { get; set; }

        public ICollection<Comment> comments  { get; set; }
    }
}
