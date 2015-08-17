using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter value of x1: ");
            double x1 = double.Parse(System.Console.ReadLine());
            System.Console.Write("Enter value of y1: ");
            double y1 = double.Parse(System.Console.ReadLine());
            System.Console.Write("Enter value of x2: ");
            double x2 = double.Parse(System.Console.ReadLine());
            System.Console.Write("Enter value of y2: ");
            double y2 = double.Parse(System.Console.ReadLine());

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("The distance is:" + distance);
        }
    }
}
