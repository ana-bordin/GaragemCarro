using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceService
    {
        IServiceRepository _serviceRepository;

        public ServiceService()
        {
            _serviceRepository = new ServiceRepository();
        }

        public bool InsertAll(List<Service> services)
        {
            return _serviceRepository.InsertAll(services);
        }

        public bool Insert(Service service)
        {
            return _serviceRepository.Insert(service);
        }

        public List<Service> GetAll()
        {
            return _serviceRepository.GetAll();
        }

    }
}
