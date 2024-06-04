using Models;
using Utilities;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sizeCarsList = 30;
            
            List<Car> cars = new List<Car>();

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
    }
}
