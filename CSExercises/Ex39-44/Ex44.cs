using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            string s = "The Titans throw the Throne to the Tank";
            Console.WriteLine(s);
            char c1 = 't', c2 = 'a';
            s = Substitute(s, c1, c2);
            Console.WriteLine(s);
        }

        public static string Substitute(string s, char c1, char c2)
        {
            s = s.ToLower().Replace(c1, c2);
            return s;
        }
    }
}
