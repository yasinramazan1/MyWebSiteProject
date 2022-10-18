// CRUD metotları BusinessLayer katmanında Abstract klasöründeki Service sınıflarında tanımlanır.
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
    }
}
