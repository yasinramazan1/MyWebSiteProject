﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager
    {
        Repository<About> repoAbout = new Repository<About>();

        public List<About> getAll()
        {
            return repoAbout.list(); // Repository'deki metotları çağırabiliyoruz.
        }
    }
}
