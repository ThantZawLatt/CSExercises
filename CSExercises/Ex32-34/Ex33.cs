using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int temp;
            int[] x = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] < x[j])
                    {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                        for(int l = 0; l < x.Length; l++)
                        {
                            Console.Write(x[l] + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
