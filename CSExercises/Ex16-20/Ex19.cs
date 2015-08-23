using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double distance, dist, totalCharge;
            System.Console.WriteLine("Enter your travelled kilometers: ");
            distance = double.Parse(System.Console.ReadLine());
            distance = Math.Ceiling(distance * 10);
            System.Console.WriteLine(distance);
            if (distance > 90)
            {
                dist = distance - 90;
                totalCharge = 2.4 + 85 * 0.04 + dist * 0.05;
            }
            else if (distance > 5)
            {
                totalCharge = 2.4 + (distance - 5) * 0.04;
            }
            else
            {
                totalCharge = 2.4;
            }
            System.Console.WriteLine("Total charge: " + totalCharge);
        }
    }
}