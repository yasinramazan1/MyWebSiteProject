using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int id { get; set; }

        [StringLength(75)]
        public string name { get; set; }

        [StringLength(250)]
        public string image { get; set; } // Dosya yolu string tanımlanır.

        [StringLength(500)]
        public string about { get; set; }

        [StringLength(75)]
        public string job { get; set; } // Yazarların mesleği

        [StringLength(120)]
        public string aboutShort { get; set; }

        [StringLength(75)]
        public string mail { get; set; }

        [StringLength(75)]
        public string password { get; set; }

        [StringLength(40)]
        public string phoneNumber { get; set; }

        [StringLength(150)]
        public string cv { get; set; }

        // İlişki türü olduğu için burada herhangi bir attribute kullanılmaz.
        public ICollection<Blog> blogs { get; set; }
    }
}
