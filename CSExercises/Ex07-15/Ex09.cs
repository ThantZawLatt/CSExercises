using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("y = 2x² - 4x + 3");
            Console.Write("Enter value of x: ");
            x = float.Parse(Console.ReadLine());
            y = 2 * x * x - (4 * x) + 3;
            Console.WriteLine("Result is: " + y);
        }
    }
}
