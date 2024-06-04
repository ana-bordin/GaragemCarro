using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarService
    {
        ICarJsonRepository _carJsonRepository;

        public CarService()
        {
            _carJsonRepository = new CarJsonRepository();
        }

        public bool InsertJson(List<Car> cars)
        {
            return _carJsonRepository.InsertJson(cars);
        }

    }
}
