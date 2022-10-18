using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> getList();
        void TAdd(T t);
        T getById(int id);
        void updateT(T t);
        void deleteT(T t);
    }
}
