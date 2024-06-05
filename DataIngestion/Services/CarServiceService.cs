using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarServiceService
    {
        ICarServiceRepository _carServiceRepository;

        public CarServiceService()
        {
            _carServiceRepository = new CarServiceRepository();
        }

        public bool InsertAll(List<Car_Service> carsServices)
        {
            return _carServiceRepository.InsertAll(carsServices);
        }

    }
}
