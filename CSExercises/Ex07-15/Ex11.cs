using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter your travelled distance: ");
            double distance = double.Parse(Console.ReadLine());
            double Fare = 2.40 + distance * 0.4;
            Console.WriteLine("Your total fare is: {0}", Fare);
        }
    }
}
