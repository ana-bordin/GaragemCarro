using Models;

namespace Repositories
{
    public interface IServiceRepository
    {
        bool InsertAll(List<Service> Services);
        bool Insert(Service services);
    }
}
