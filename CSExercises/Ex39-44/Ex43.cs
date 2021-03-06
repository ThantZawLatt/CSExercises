using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hexadecimal From 1-100");
            for (int j = 1; j <= 100; j++)
            {
                Console.Write("{0:x} ", j);
            }
            Console.WriteLine();
            Console.Write("Enter a decimal number: ");
            Console.WriteLine("The hexadecimal of your number: {0}", Hex(int.Parse(Console.ReadLine())));
        }

        public static string Hex(int i)
        {
            if(i % 16 == 0)
            {
              return ((i / 16) + "0");
            }
            else
            {
                if (i < 10)
                {
                    return i.ToString();
                }
                else if(i % 10 < 6)
                {
                    string hexa;
                    if (i / 10 > 1)
                    {
                        hexa = (i / 10 - 1).ToString();
                    }
                    else
                        hexa = "";
                    switch(i % 10)
                    {
                        case 1: return hexa + "a";
                        case 2: return hexa + "b";
                        case 3: return hexa + "c";
                        case 4: return hexa + "d";
                        case 5: return hexa + "e";
                        case 6: return hexa + "f";
                    }
                }
                else if (i % 16 > 0)
                {
                    return (i / 16).ToString() + (i % 16).ToString();
                }
                return null;
            }
        }
    }
}
