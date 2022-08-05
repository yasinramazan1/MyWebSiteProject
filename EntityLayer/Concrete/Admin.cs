﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string userName { get; set; }

        [StringLength(50)]
        public string password { get; set; }


    }
}
