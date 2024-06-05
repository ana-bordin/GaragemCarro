using Models;
using Services;

namespace Controllers
{
    public class ServiceController
    {
        private readonly ServiceService _serviceService;

        public ServiceController()
        {
            _serviceService = new ServiceService();
        }

        public bool InsertAll(List<Service> services)
        {
            return _serviceService.InsertAll(services);
        }
    }
}
