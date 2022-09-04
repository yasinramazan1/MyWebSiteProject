using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> getList();
        void contactAdd(Contact contact);
        Contact getById(int id);
        void updateContact(Contact contact);
        void deleteContact(Contact contact);
    }
}
