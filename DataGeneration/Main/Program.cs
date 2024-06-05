using Controllers;
using Models;
using Repositories;
using Utilities;

namespace Main
{
    internal class Program
    {
        static int sizeCarsList = 30;
        static Random random = new Random();
        static List<Car> cars = new List<Car>();
        static List<Car_Service> carServices = new List<Car_Service>();
        static List<Service> services = new List<Service>()
        {
            new Service { Description = "Limpeza exterior e interior do carro." },
            new Service { Description = "Substituição do óleo do motor." },
            new Service { Description = "Ajuste do equilíbrio dos pneus." },
            new Service { Description = "Correção do alinhamento das rodas." },
            new Service { Description = "Inspeção e substituição de pastilhas e discos de freio." },
            new Service { Description = "Substituição dos pneus antigos por novos." },
            new Service { Description = "Substituição de filtros de óleo, ar, combustível e cabine." },
            new Service { Description = "Restauração do brilho da pintura e aplicação de cera protetora." }
        };

        static void CreateListCarService()
        {
            for (int i = 0; i < sizeCarsList; i++)
            {
                Car_Service carService = new Car_Service
                {
                    Car = cars[random.Next(0, cars.Count-1)],
                    Service = services[random.Next(0, services.Count-1)],
                    Status = random.Next(0, 2) == 0 ? false : true
                };
                carServices.Add(carService);
            }
        }

        static void CreateListCar()
        {
            for (int i = 0; i < sizeCarsList; i++)
            {
                string licensePlate = LicensePlateGenerator.GenerateLicensePlate();
                string carColor = CarColorGenerator.GenerateCarColor();

                Car car = new Car
                {
                    LicensePlate = licensePlate,
                    Name = "Car" + i,
                    ModelYear = random.Next(1900, 2022),
                    ManufactureYear = random.Next(1900, 2022),
                    Color = carColor
                };
                cars.Add(car);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir dados nos arquivo.json:");
            CreateListCar();
            CreateListCarService();

            if (JsonRepository.InsertJson(cars, services, carServices))
                Console.WriteLine("Registros inseridos com sucesso!");

            Console.WriteLine("Inserir dados no banco de dados:");
            CarController carController = new CarController();
            if (carController.InsertAll(cars))
                Console.WriteLine("Registros inseridos com sucesso!");

        }
    }
}
