using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[,] students = new string[,]
            {
                {"John", "63"}, {"Venkat", "29"},
                {"Mary", "75"}, {"Victor", "82"},
                {"Betty", "55"}
            };
            string[,] sortByMarks = new string[,] { { "", "" } };
            string[,] sortByNames = new string[,] { { "", "" } };
            Console.WriteLine("Sorted By Mark");
            Console.WriteLine("Name \t Mark");
            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = i + 1; j < students.GetLength(0); j++)
                {
                    if (Convert.ToInt32(students[i, 1]) < Convert.ToInt32(students[j, 1]))
                    {
                        sortByMarks[0, 0] = students[i, 0];
                        sortByMarks[0, 1] = students[i, 1];
                        students[i, 0] = students[j, 0];
                        students[i, 1] = students[j, 1];
                        students[j, 0] = sortByMarks[0, 0];
                        students[j, 1] = sortByMarks[0, 1];
                    }
                }
            }
            for (int k = 0; k < students.GetLength(0); k++)
            {
                Console.WriteLine(students[k, 0] + " \t " + students[k, 1]);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted By Name");
            Console.WriteLine("Name \t Mark");
            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = i + 1; j < students.GetLength(0); j++)
                {
                    if (students[i, 0].CompareTo(students[j, 0]) > 0)
                    {
                        sortByNames[0, 0] = students[i, 0];
                        sortByNames[0, 1] = students[i, 1];
                        students[i, 0] = students[j, 0];
                        students[i, 1] = students[j, 1];
                        students[j, 0] = sortByNames[0, 0];
                        students[j, 1] = sortByNames[0, 1];
                    }
                }
            }
            for (int k = 0; k < students.GetLength(0); k++)
            {
                Console.WriteLine(students[k, 0] + " \t " + students[k, 1]);
            }
        }
    }
}
