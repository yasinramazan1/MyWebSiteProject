using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Annotation kullanımı için gerekli olan kütüphanedir.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        // [] kullanımına attribute kullanımı denir. "Annotation" kavramı bu kullanıma denir. 

        [Key] // Primary Key tanımlaması 
        public int id { get; set; }

        [StringLength(750)] // SQL bu tanımlamayı nvarchar türünde algılar.
        public string content1 { get; set; }

        [StringLength(750)]
        public string content2 { get; set; }

        [StringLength(250)]
        public string image1 { get; set; }

        [StringLength(250)]
        public string image2 { get; set; }
    }
}
