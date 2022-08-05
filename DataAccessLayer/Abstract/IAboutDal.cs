using EntityLayer.Concrete; // About sınıfını çağırabilmek için About sınıfının tanımlı olduğu kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // Bu şekilde her sınıf için ayrı ayrı tanımlama yapılmalıdır. Ancak bunu kısaltmanın diğer bir yolu da "generic" yapıları kullanmaktır.
    public interface IAboutDal:IRepository<About>
    {
    }
}
