using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double N = double.Parse(Console.ReadLine());
            double x = new Random().NextDouble();
            x = x * (N - 1);
            x = x + 1;
            double G = x;
            bool result;
            do
            {
                result = Math.Abs((G * G) - N) < 0.00001; ;

                if (result == false)
                {
                    G = (G + N / G) / 2;
                }
            } while (result == false);
            Console.WriteLine(G);
        }
    }
}
