using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.DAL.Interfaces
{
    internal interface IBaseRepository<T>
    {
        bool Create(T entity);
        T GetT(int id);
        IEnumerable<T> Select();
        bool Delete(T entity);

    }
}
