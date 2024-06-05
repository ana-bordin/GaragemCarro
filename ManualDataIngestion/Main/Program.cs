using Controllers;
using Models;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarController carController = new CarController();
            List<Car> cars = carController.GetAll();

            Console.WriteLine("Ingestão manual de Dados");
            string opcao;
            do
            {
                Console.WriteLine("A opçao desejada:");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Inserir um novo registro de carro");
                        break;
                    case "2":
                        Console.WriteLine("Inserir um novo registro de serviço");
                        break;
                    case "3":
                        Console.WriteLine("Inserir um novo registro de de serviço do carro");
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
