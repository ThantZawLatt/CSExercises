using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string String;
            System.Console.Write("Please enter a sentence: ");
            String = Console.ReadLine();
            char ch1 = 'a';
            char ch2 = 'e';
            char ch3 = 'i';
            char ch4 = 'o';
            char ch5 = 'u';

            int countOfa = 0;
            int countOfe = 0;
            int countOfi = 0;
            int countOfo = 0;
            int countOfu = 0;

            char ch6 = 'A';
            char ch7 = 'E';
            char ch8 = 'I';
            char ch9 = 'O';
            char ch10 = 'U';

            int countOfA = 0;
            int countOfE = 0;
            int countOfI = 0;
            int countOfO = 0;
            int countOfU = 0;

            int j = countOfa + countOfe + countOfi + countOfo + countOfu + countOfA + countOfE + countOfI + countOfO + countOfU;
           
            foreach (char v in String)
            {
                if (v == ch1) { countOfa++; j++; }

                else if (v == ch2) { countOfe++; j++; }

                else if (v == ch3) { countOfi++; j++; }

                else if (v == ch4) { countOfo++; j++; }

                else if (v == ch5) { countOfu++; j++; }
            }
            foreach (char v in String)
            {
                if (v == ch6) { countOfA++; j++; }

                else if (v == ch7) { countOfE++; j++; }

                else if (v == ch8) { countOfI++; j++; }

                else if (v == ch9) { countOfO++; j++; }

                else if (v == ch10) { countOfU++; j++; }
            }

            int a = countOfa + countOfA;
            int e = countOfe + countOfE;
            int i = countOfi + countOfI;
            int o = countOfo + countOfO;
            int u = countOfu + countOfU;

            System.Console.WriteLine("Total counts of vowel: " + j);
            System.Console.WriteLine(" counts of a: " + a);
            System.Console.WriteLine(" counts of e: " + e);
            System.Console.WriteLine(" counts of i: " + i);
            System.Console.WriteLine(" counts of o: " + o);
            System.Console.WriteLine(" counts of u: " + u);
        }
    }
}
