using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int secretNum = new Random().Next(0, 10);
            int guessNum, count = 0;
            do
            {
                count++;
                Console.Write("Think of a number: ");
                guessNum = int.Parse(Console.ReadLine());
                if (guessNum == secretNum)
                {
                    Console.WriteLine("Congratulation!!!");
                    Console.WriteLine("Total attempts: {0}", count);
                    if (count <= 2)
                    {
                        Console.WriteLine("You are a wizard!");
                    }
                    else if (count > 2 && count <= 5)
                    {
                        Console.WriteLine("You are a good guess");
                    }
                    else
                        Console.WriteLine("You are lousy!");
                }
                else
                    Console.WriteLine("Try again!");
            } while (secretNum != guessNum);
        }
    }
}
