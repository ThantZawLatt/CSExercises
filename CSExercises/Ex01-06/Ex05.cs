using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num = Double.Parse(Console.ReadLine());
            num = Math.Sqrt(num);
            Console.WriteLine("Your result is {0:0.000}", num);
        }
    }
}
