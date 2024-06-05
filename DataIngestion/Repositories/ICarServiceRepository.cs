using Models;

namespace Repositories
{
    public interface IServiceRepository
    {
        bool InsertAll(List<Service> services);
        bool Insert(Service service);
    }
}
