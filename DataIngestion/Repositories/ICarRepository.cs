using Models;

namespace Repositories
{
    public interface ICarRepository
    {
        bool InsertAll(List<Car> cars);
        bool Insert(Car car);
        List<Car> GetAll();
        List<Car> GetAllRedCars();
        List<Car> GetAllCarsBetween2010And2011();
    }
}
