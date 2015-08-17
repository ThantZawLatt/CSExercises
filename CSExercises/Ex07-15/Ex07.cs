using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double salary, hAllowance, tAllowance;
            System.Console.Write("Enter Salary: ");
            salary = Double.Parse(Console.ReadLine());
            hAllowance = salary * 0.1;
            tAllowance = salary * 0.03;
            salary += hAllowance + tAllowance;
            Console.WriteLine("Salary after allowance: ${0}", salary);
        }
    }
}
