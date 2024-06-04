using System;

namespace Utilities
{
    public class LicensePlateGenerator
    {
        static List<char> chars = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static string GenerateLicensePlate()
        {
            int randomIndex;
            char randomChar;
            string licensePlate = null;
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                if (i < 3 || i == 4)
                {
                    randomIndex = random.Next(chars.Count);
                    randomChar = chars[randomIndex];
                    licensePlate += randomChar;
                }
                else
                {
                    int randomNumber = random.Next(10);
                    licensePlate += randomNumber;
                }
            }
            return licensePlate;
        }
    }
}
