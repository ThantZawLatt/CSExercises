using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a pharse: ");
            string phrase = Console.ReadLine();
            string removePunc = phrase.ToLower();
            string palindrome = "";
            bool isTrue = false;
            char[] punc = new char[] { '\'', '\\' , '.', '?', '!', ',', ';', ':', '-', '_', '(', ')', '{', '}', '"', '*', ' ' };
            for(int i = 0; i < punc.Length; i++)
            {
                removePunc = removePunc.Replace(punc[i].ToString(), "");
            }
            for(int j = removePunc.Length - 1; j >= 0; j--)
            {
                palindrome += removePunc[j];
            }
            if (removePunc == palindrome)
            {
                Console.WriteLine("This is Palindrome");
            }
            else
            {
                Console.WriteLine("This is not Palindrome");
            }
        }
    }
}
