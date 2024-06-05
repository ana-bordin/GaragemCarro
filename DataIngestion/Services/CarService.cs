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
        ICarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }

        public bool InsertAll(List<Car> cars)
        {
            return _carRepository.InsertAll(cars);
        }

        public bool Insert(Car car)
        {
            return _carRepository.Insert(car);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public List<Car> GetAllRedCars()
        {
            return _carRepository.GetAllRedCars();
        }
        public List<Car> GetAllCarsBetween2010And2011()
        {
            return _carRepository.GetAllCarsBetween2010And2011();
        }
    }
}
