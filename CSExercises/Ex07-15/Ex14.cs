using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double area;
            double[] i = new double[4];
            Console.Write("Enter value of a, b , c in order: ");
            for (int j = 0; j < 3; j++)
            {
                i[j] = Double.Parse(Console.ReadLine());
            }
            i[3] = (i[0] + i[1] + i[2]) / 2;
            area = Math.Sqrt(i[3] * (i[3] - i[0]) * (i[3] - i[1]) * (i[3] - i[2]));
            Console.WriteLine("Area is " + area);
        }
    }
}