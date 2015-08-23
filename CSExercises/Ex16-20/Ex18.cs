using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your mark: ");
            int mark = int.Parse(Console.ReadLine());
            if (mark >= 0 && mark <= 100)
            {
                if(mark >= 80)
                {
                    Console.WriteLine("Your scored {0} marks which is A grade.", mark);
                }
                else if (mark >= 60)
                {
                    Console.WriteLine("Your scored {0} marks which is B grade.", mark);
                }
                else if (mark >= 40)
                {
                    Console.WriteLine("Your scored {0} marks which is C grade.", mark);
                }
                else
                    Console.WriteLine("Your scored {0} marks which is F grade.", mark);
            }
            else
                Console.WriteLine("Error!Marks should be between 0 and 100.");
        }
    }
}