using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            string firstString, secondString;
            Console.Write("Enter first string: ");
            firstString = Console.ReadLine();
            Console.Write("Enter second string: ");
            secondString = Console.ReadLine();
            Console.WriteLine(FindWord(firstString, secondString));
        }

        public static int FindWord(string s1, string s2)
        {
            int k = 0, l = 0, count = 0;
                for (int i = 0; i < s2.Length; i++)
                {
                    for (int j = k; j < s1.Length; j++)
                    {
                        if (s1[j] == s2[i])
                        {
                            k = j + 1;
                            count++;
                            if(count == 1)
                            {
                                l = j;
                            }
                            break;
                        }
                    }
                }
                if (count == s2.Length)
                    return l;
                else
                    return -1;
        }
    }
}
