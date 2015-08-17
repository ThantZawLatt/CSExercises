using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter your travelled distance: ");
            double distance = double.Parse(Console.ReadLine());
            double Fare = Math.Ceiling(2.40 + distance * 0.4);
            Console.WriteLine("Your total fare is: {0:0.00}", Fare);
        }
    }
}
