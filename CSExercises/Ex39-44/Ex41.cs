using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            string firstString, secondString;
            Console.Write("Enter first string: ");
            firstString = Console.ReadLine();
            Console.Write("Enter second string: ");
            secondString = Console.ReadLine();
            if (InString(firstString, secondString))
            {
                Console.WriteLine("Same!");
            }
            else
                Console.WriteLine("Not Same!");
        }

        public static bool InString(string s1, string s2)
        {
            int k = 0, count = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                for(int j = k; j < s1.Length; j++)
                {
                    if(s1[j] == s2[i])
                    {
                        k = j + 1;
                        count++;
                        break;
                    }
                }
            }
            if (count == s2.Length)
                return true;
            else
                return false;
        }
    }
}
