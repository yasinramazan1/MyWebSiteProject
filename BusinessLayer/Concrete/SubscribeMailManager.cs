using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> repoSubscribeMail = new Repository<SubscribeMail>();
        public void BLAdd(SubscribeMail p)
        {
            //if (p.mail.Length <= 11 || p.mail.Length >= 50 )
            //{
            //    return -1;
            //}
            repoSubscribeMail.insert(p);
        }
    }
}