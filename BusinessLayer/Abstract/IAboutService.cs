﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> getList();
        void aboutAdd(About about);
        About getById(int id);
        void updateAbout(About about);
        void deleteAbout(About about);
    }
}