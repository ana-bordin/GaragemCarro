using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class CarColorGenerator
    {
        public static string GenerateCarColor()
        {
            List<string> carColors = new List<string> { "Red", "Blue", "Green", "Black", "White", "Silver", "Gray", "Yellow", "Orange", "Brown", "Purple", "Beige", "Cyan", "Magenta" };
            Random random = new Random();
            int randomIndex = random.Next(carColors.Count);
            return carColors[randomIndex];
        }
    }
}
