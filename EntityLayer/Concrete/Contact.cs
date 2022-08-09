using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int id { get; set; }

        [StringLength(75)]
        public string name { get; set; }

        [StringLength(50)]
        public string surName  { get; set; }

        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(100)]
        public string subject { get; set; }

        public string message { get; set; }

        public DateTime messageDate { get; set; }
    }
}
