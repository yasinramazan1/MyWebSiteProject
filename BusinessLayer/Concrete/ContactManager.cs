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
    public class ContactManager : IContactService
    {

        IContactDal _contactDal;

        Repository<Contact> repoContact = new Repository<Contact>();

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void deleteT(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact getById(int id)
        {
            return _contactDal.find(x => x.id == id);
        }

        public List<Contact> getList()
        {
            return _contactDal.list();
        }

        public void TAdd(Contact t)
        {
            _contactDal.insert(t);
        }

        public void updateT(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
