using Controllers;
using Models;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarController carController = new CarController();
            //List<Car> cars = carController.GetAll();


            Console.WriteLine("Ingestão manual de Dados");
            string opcao;
            do
            {    
                Console.WriteLine("1 - Inserir um novo registro de carro");
                Console.WriteLine("2 - Inserir um novo registro de serviço");
                Console.WriteLine("3 - Inserir um novo registro de de serviço do carro");
                Console.WriteLine("0 - Sair");

                Console.WriteLine("Digite o opçao desejada:");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Inserir um novo registro de carro");
                        Console.WriteLine("Digite a placa do carro:");
                        string licensePlate = Console.ReadLine();
                        Console.WriteLine("Digite a marca do carro:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Digite o ano do modelo do carro:");
                        int modelYear = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o ano produção do carro:");
                        int manufactureYear = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a cor do carro:");
                        string cor = Console.ReadLine();

                        Car car = new Car()
                        {
                            LicensePlate = licensePlate,
                            Name = name,
                            ModelYear = modelYear,
                            ManufactureYear = manufactureYear,
                            Color = cor            
                        };

                        CarController carController = new CarController();
                        carController.Insert(car);
                        break;

                    case "2":
                        Console.WriteLine("Inserir um novo registro de serviço");

                        Console.WriteLine("Digite o nome do serviço:");
                        string description = Console.ReadLine();

                        Service service = new Service()
                        {
                            Description = description
                        };
                        ServiceController serviceController = new ServiceController();
                        serviceController.Insert(service);
                        break;

                    case "3":
                        Console.WriteLine("Inserir um novo registro de de serviço do carro");

                        Console.WriteLine("Digite a placa do carro:");
                        string licensePlateCar = Console.ReadLine();
                        Console.WriteLine("Digite o nome do serviço:");
                        string descriptionService = Console.ReadLine();
                        Console.WriteLine("Digite o status do serviço: C - Completo, I - Incompleto");
                        string status = Console.ReadLine();

                        Car_Service carService = new Car_Service()
                        {
                            Car = new Car() { LicensePlate = licensePlateCar },
                            Service = new Service() { Description = descriptionService },
                            Status = status == "C" ? true : false   
                        };

                        CarServiceController carServiceController = new CarServiceController();
                        carServiceController.Insert(carService);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != "0");
        }
    }
}
