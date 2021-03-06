using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            double[] x = new double[12];
            int i;
            double minSale = -1, maxSale = -1, averageSale = 0;
            for(i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month {0}: ", i);
                x[i] = double.Parse(Console.ReadLine());
                if (minSale < 0)
                {
                    minSale = x[i];
                }
                if(minSale > x[i])
                {
                    minSale = x[i];
                }
                if(x[i] > maxSale)
                {
                    maxSale = x[i];
                }
                averageSale += x[i];
            }
            Console.WriteLine("Maximum Sales: {0}", maxSale);
            Console.WriteLine("Minimum Sales: {0}", minSale);
            Console.WriteLine("Average Sales: {0}", averageSale / 12);
        }
    }
}
