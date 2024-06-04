using Controllers;
using Models;
using Utilities;

namespace Main
{
    internal class Program
    {
        static List<Car> cars = new List<Car>();

        static void CreateList()
        {
            Random random = new Random();
            int sizeCarsList = 30;

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
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir dados nos arquivo.json:");
            CarController carController = new CarController();

            if (carController.InsertJson(cars))
                Console.WriteLine("Registros inseridos com sucesso!");
            
        }
    }
}
