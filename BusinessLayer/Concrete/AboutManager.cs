using DataAccessLayer.Concrete;
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

        public int updateAboutBM(About p)
        {
            About about = repoAbout.find(x => x.id== p.id);
            about.content1 = p.content1;
            about.content2 = p.content2;
            about.image1 = p.image1;
            about.image2 = p.image2;
            about.id = p.id;
            return repoAbout.update(about);
        }
    }
}
