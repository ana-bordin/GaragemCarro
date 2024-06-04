using Models;
using Services;

namespace Controllers
{
    public class CarController
    {
        private readonly CarService _carService;

        public CarController()
        {
            _carService = new CarService();
        }

        public bool InsertJson(List<Car> cars)
        {
            return _carService.InsertJson(cars);
        }

    }
}
