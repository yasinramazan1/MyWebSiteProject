using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        public string userName { get; set; }

        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(400)] // Yorumu spam'letmemek için kısıtlama getiriyoruz.
        public string text { get; set; }

        public DateTime commentDate { get; set; }

        public bool status { get; set; }

        public int blogRating { get; set; }

        public int blogId { get; set; }
        public virtual Blog blog { get; set; }
    }
}
