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

        public bool Insert(Car_Service carService)
        {
            return _carServiceRepository.Insert(carService);
        }

        public List<Car_Service> GetAll()
        {
            return _carServiceRepository.GetAll();
        }

        public List<Car> GetCarsInProgress()
        {
            return _carServiceRepository.GetCarsInProgress();
        }
    }
}
