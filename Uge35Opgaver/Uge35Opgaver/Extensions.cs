using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class Extensions
    {
        //Øvelse 1 og 2 - Test af Capitalize()-metode
        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str; 
            }
            
            else
            {
                str = char.ToUpper(str[0]) + str.Substring(1);
                return str;
            }
            
        }
        // Øvelse 3.1 - NextDouble()
        public static double NextDouble(this double d)
        {
            
            var random = new Random();
            return random.NextDouble() * (d - 0) + 0; 
            
        }

        //Øvelse 3.2 - Plat eller krone 

       
        // Plat = true, Krone = false 
        public static bool CoinFlip(this Random random)
        {

            int randomNumber = random.Next(0, 101); 
            
            if (random.Next() >= 0 && random.Next() <= 25)
            {
                return randomNumber < 25;
            }

            if (random.Next() > 50 && random.Next() <= 75)
            {
                return randomNumber < 75;
            }
           

            if (random.Next() == null)
            {
                return randomNumber < 50;

            }

            return randomNumber < 50;


        }

        // Alternativ metode
        public static bool CoinFlip(this double frekvens)
        {
            // Ensure that the likelihood is in the range [0.0, 1.0]
            if (frekvens < 0.0) frekvens = 0.0;
            if (frekvens > 1.0) frekvens = 1.0;

            Random random = new Random();
            double result = random.NextDouble(); // Generates a random number between 0.0 and 1.0

            return result < frekvens; // Returns true if the random number is less than frekvens, false otherwise
        }

        //Øvelse 3.3 - Random string

        public static string NextString(this string[] StringArray)
        {
            int length = StringArray.Length;

            var random = new Random();

            int randomStringNumber = random.Next(0,length);
           
            return StringArray[randomStringNumber];

        }
    }
}
