using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarServiceRepository : ICarServiceRepository
    {
        private string _conn { get; set; }

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
                            var query = "INSERT INTO Car_Service (LicensePlate, ServiceId, Status) VALUES (@LicensePlate, @ServiceId, @Status)";
                            var result = db.Execute(query, new { LicensePlate = carService.Car.LicensePlate, ServiceId = carService.Service.Id, Status = carService.Status }, transaction);
                            
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

        public bool Insert(Car_Service carsServices)
        {
                using (var db = new SqlConnection(_conn))
                {
                    try
                    {
                        db.Open();
                    db.Execute("INSERT INTO Car_Service (LicensePlate, ServiceId, Status) VALUES (@LicensePlate, @ServiceId, @Status)", new { LicensePlate = carsServices.Car.LicensePlate, ServiceId = carsServices.Service.Id, Status = carsServices.Status });
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro ao inserir no banco de dados. Erro:" + e.Message);
                        return false;
                    }
                }
            }

        public List<Car_Service> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var carsServices = db.Query<Car_Service>("SELECT * FROM Car_Service").AsList();
                return carsServices;
            }
        }
    }
}
