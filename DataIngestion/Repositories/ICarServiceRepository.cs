using Models;

namespace Repositories
{
    public interface ICarServiceRepository
    {
        bool InsertAll(List<Car_Service> carsServices);
        bool Insert(Car_Service carService);
        List<Car_Service> GetAll();
        List<Car> GetCarsInProgress();
    }
}
