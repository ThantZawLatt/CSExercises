using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            for (int num = 5; num <= 10000; num ++)
            {
                int i;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        break;
                    }
                }
                if (num % i != 0)
                    Console.WriteLine(num + " is a prime");
            }
        }
    }
}
