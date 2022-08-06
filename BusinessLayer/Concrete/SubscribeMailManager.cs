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
        public int BLAdd(SubscribeMail p)
        {
            if (p.mail.Length <= 11 || p.mail.Length >= 100)
            {
                return -1;
            }
            return repoSubscribeMail.insert(p);
        }
    }
}