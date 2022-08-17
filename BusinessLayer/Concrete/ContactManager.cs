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
            if (c.mail == "" || c.message == "" || c.name == "" || c.surName == "" || c.subject == "")
            {
                return -1;
            }
            return repoContact.insert(c); // Repository'deki metotları çağırabiliyoruz.
        }

        public List<Contact> getAll()
        {
            return repoContact.list(); // Repository'deki metotları çağırabiliyoruz.
        }

        public Contact getMessageDetails(int id)
        {
            // Dışarıdan gönderilen id parametresine veri tabanında denk gelen id'nin detaylarını getiren metot budur.
            return repoContact.find(x => x.id == id);
        }
    }
}
