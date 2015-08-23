using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your gender(M/F): ");
            string gender = Console.ReadLine();
            if(gender == "M")
            {
                Console.WriteLine("Good Morning, Mr.{0}!", name);
            }
            else
            Console.WriteLine("Good Morning, Ms.{0}!", name);
        }
    }
}