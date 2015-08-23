using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number for factorial: ");
            int factorial = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= factorial; i++)
            {
                num *= i;
                if (i != factorial)
                    Console.Write(i + "*");
                else
                    Console.Write(i);
            }
            Console.WriteLine("= {0}", num);
            num = 1;
            for (int i = factorial; i >= 1; i--)
            {
                num *= i;
                if (i != 1)
                    Console.Write(i + "*");
                else
                    Console.Write(i);
            }
            Console.WriteLine("= {0}", num);
        }
    }
}
