using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automarket.DAL.Interfaces;
using CarShop.Domain.Entity;

namespace Automarket.DAL.Repositories
{
    internal class CarRepository : ICarRepository
    {
        public bool Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Car GetT(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> Select()
        {
            throw new NotImplementedException();
        }
    }
}
