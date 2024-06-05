using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class JsonRepository
    {
        private static string _path = "C:\\repositories\\GaragemCarro\\Files\\";
        private static string _data = "Data";
        private static string _json = ".json";
        private static string _dataCarServiceJson = "DataCarService.json";
        private static string _dataServiceJson = "DataService.json";
        static List<string> list = new List<string>() { "Car", "Service", "CarService" };
        public static void CheckExists(string type)
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            if (!Directory.Exists(_path + _data + type + _json))
            {
                StreamWriter sw = new(_path + _data + type + _json);
                sw.Close();
            }

        }

        public static bool InsertJson(List<Car> cars, List<Service> services, List<Car_Service> carServices)
        {
            try
            {
                for (int i = 0; i < 3 ; i++)
                {
                    string jsonString = null;
                    CheckExists(list[i]);
                    if (i == 0)
                        jsonString = JsonConvert.SerializeObject(cars);
                    if (i == 1)
                        jsonString = JsonConvert.SerializeObject(services);
                    if (i == 2)
                        jsonString = JsonConvert.SerializeObject(carServices);
                    StreamWriter writer = new StreamWriter(_path + _data + list[i] + _json);
                    writer.Write(jsonString);
                    writer.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir no arquivo.json. Erro:" + e.Message);
                return false;
            }
        }
    }
}
