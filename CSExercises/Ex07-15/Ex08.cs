using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double temperature;
            Console.Write("Enter Temperature in Centigrade: ");
            temperature = Double.Parse(Console.ReadLine());
            temperature = 1.8 * temperature + 32;
            Console.WriteLine("Temperature in Fahrenheit: {0}", temperature);
        }
    }
}
