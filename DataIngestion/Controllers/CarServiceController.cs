using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CarServiceController
    {
        private readonly CarServiceService _carServiceService;

        public CarServiceController()
        {
            _carServiceService = new CarServiceService();
        }

        public bool InsertAll(List<Car_Service> carsServices)
        {
            return _carServiceService.InsertAll(carsServices);
        }
    }
}
