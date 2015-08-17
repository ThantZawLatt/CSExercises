using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int number, a, b, c;
            System.Console.Write("Enter 3 digit number: ");
            number = int.Parse(System.Console.ReadLine());
            if (number > 99 && 1000 > number)
            {
                a = number / 100;
                b = (number % 100) / 10;
                c = number % 10;
                if (number == (a * a * a) + (b * b * b) + (c * c * c))
                {
                    System.Console.WriteLine("This is an armstrong number");
                }
                else
                    System.Console.WriteLine("This is not an armstrong number");
            }
            else
                System.Console.WriteLine("Please enter only 3 digit number");
        }
    }
}