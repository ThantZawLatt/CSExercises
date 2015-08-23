using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string str;
            Console.Write("Please enter a sentence: ");
            str = Console.ReadLine();
            string[] array = str.Split(new char[] {' '});
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                string word = array[i] + " ";

                if (word.Length > 1)
                {
                    word = word.ToUpper().Substring(0, 1) + word.Substring(1, word.Length - 1);
                    result = result + word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
