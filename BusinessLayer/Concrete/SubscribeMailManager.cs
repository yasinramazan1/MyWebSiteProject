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
    public class SubscribeMailManager : IMailService
    {
        IMailDal _mailDal;
        
        public SubscribeMailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public void deleteT(SubscribeMail t)
        {
            throw new NotImplementedException();
        }

        public SubscribeMail getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubscribeMail> getList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubscribeMail t)
        {
            _mailDal.insert(t);
        }

        public void updateT(SubscribeMail t)
        {
            throw new NotImplementedException();
        }
    }
}