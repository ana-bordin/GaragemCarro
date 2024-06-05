using Models;

namespace Repositories
{
    public interface ICarServiceRepository
    {
        bool InsertAll(List<Car_Service> carsServices);
        bool Insert(Car_Service carService);
    }
}
