using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repoContact = new Repository<Contact>();

        public int BLContactAdd(Contact c)
        {
            if (c.mail == "" || c.message == "" || c.name == "" || c.surName == "" || c.subject == "" || c.mail.Length <= 10 || c.subject.Length <= 3)
            {
                return -1;
            }
            return repoContact.insert(c); // Repository'deki metotları çağırabiliyoruz.
        }
    }
}
