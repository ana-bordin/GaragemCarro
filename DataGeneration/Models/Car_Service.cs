using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car_Service
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public Service Service { get; set; }
        public bool Status { get; set; }
    }
}
