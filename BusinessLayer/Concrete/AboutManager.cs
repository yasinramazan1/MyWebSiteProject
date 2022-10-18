using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        Repository<About> repoAbout = new Repository<About>();

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }    

        public void deleteT(About t)
        {
            throw new NotImplementedException();
        }

        public About getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> getList()
        {
            return _aboutDal.list();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void updateT(About t)
        {
            _aboutDal.update(t);
        }
    }
}
