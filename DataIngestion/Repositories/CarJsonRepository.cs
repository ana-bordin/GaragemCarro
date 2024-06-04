using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarJsonRepository : ICarJsonRepository
    {
        private static string _path = "C:\\repositories\\GaragemCarro\\Files\\";
        private static string _dataJson = "Data.json";
        
        public static void CheckExists()
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            if (!Directory.Exists(_path + _dataJson))
            {
                StreamWriter sw = new(_path + _dataJson);
                sw.Close();
            }
        }
        public bool InsertJson(List<Car> cars)
        {
            try
            {
                CheckExists();
                string jsonString = JsonConvert.SerializeObject(cars);
                StreamWriter writer = new StreamWriter(_path + _dataJson);
                writer.Write(jsonString);
                writer.Close();
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
