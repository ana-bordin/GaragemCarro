using Controllers;
using Models;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarController carController = new CarController();
            CarServiceController carsServiceController = new CarServiceController();
            List<Car> cars = new List<Car>();
            Console.WriteLine("Ingestão manual de Dados");
            string opcao;
            do
            {
                Console.WriteLine("1 - Mandar todos dados para XML");
                Console.WriteLine("2 - Retornar todos os carros que estão com o serviço em andamento");
                Console.WriteLine("3 - Retornar todos carros vemelhos existentes");
                Console.WriteLine("4 - Retornar todos carros que tenham sido fabricados entre 2010 e 2011");
                Console.WriteLine("0 - Sair");

                Console.WriteLine("Digite o opçao desejada:");
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Mandar todos dados para XML");
                        break;
                    case "2":
                        Console.WriteLine("Retornar todos os carros que estão com o serviço em andamento");

                        
                        List<Car> CarsInProgress = carsServiceController.GetCarsInProgress();
                        foreach (var car in CarsInProgress)
                            Console.WriteLine(car.ToString());
                        break;

                    case "3":
                        Console.WriteLine("Retornar todos carros vemelhos existentes");
                        
                        cars = carController.GetAllRedCars();
                        foreach (var car in cars)
                            Console.WriteLine(car.ToString());
                        cars.Clear();
                        break;
                        
                    case "4":
                        Console.WriteLine("Retornar todos carros que tenham sido fabricados entre 2010 e 2011");
                        
                        cars = carController.GetAllCarsBetween2010And2011();
                        foreach (var car in cars)
                            Console.WriteLine(car.ToString());
                        cars.Clear();
                        break;

                    case "0":
                        Console.WriteLine("Sair");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (true);
        }
    }
}



