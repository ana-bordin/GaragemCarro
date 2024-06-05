using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarServiceRepository : ICarServiceRepository
    {
        public string _conn { get; set; }

        public CarServiceRepository()
        {
            _conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertAll(List<Car_Service> carsServices)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        foreach (var carService in carsServices)
                        {
                            var query = "INSERT INTO Car_Service (CarId, ServiceId, Status) VALUES (@CarId, @ServiceId, @Status)";



                            var query = "INSERT INTO Car (LicensePlate, Name, ModelYear, ManufactureYear, Color) VALUES (@LicensePlate, @Name, @ModelYear, @ManufactureYear, @Color)";
                            var result = db.Execute(query, new {LicensePlate = carService.LicensePlate, Name = car.Name, ModelYear = car.ModelYear, ManufactureYear = carService.ManufactureYear, Color = car.Color }, transaction);
                            
                            if (result == 0)
                            {
                                transaction.Rollback();
                                return false;
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro ao inserir no banco de dados. Erro:" + e.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool Insert(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
