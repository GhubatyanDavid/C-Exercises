using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShop.Domain.Entity;

namespace Automarket.DAL.Interfaces
{
    internal interface ICarRepository: IBaseRepository<Car>
    {
        Car GetByName(string name);

    }
}
