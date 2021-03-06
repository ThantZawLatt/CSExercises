using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] theArray = new int[,]
            {
                {56, 84, 68, 29}, {94, 73, 31, 89}, {41, 63, 36, 90}, {99, 9, 18, 17},
                {62, 3, 65, 75}, {40, 96, 53, 23}, {81, 15, 27, 30}, {21, 70, 100, 22},
                {88, 50, 13, 12}, {48, 54, 52, 78}, {64, 71, 67, 25}, {16, 93, 46, 72}
            };
            int[] totalMarks = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    totalMarks[i] += theArray[i, j];
                }
                Console.WriteLine("Student {0}'s total marks: {1}", i + 1, totalMarks[i]);
            }
            Console.WriteLine();

            int[] avg = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int avgOfTotalMarks = 0;
            for (int i = 0; i < theArray.GetLength(1); i++)
            {
                for (int j = 0; j < theArray.GetLength(0); j++)
                {
                    avg[i] += theArray[j, i];
                }
                avgOfTotalMarks += avg[i] / theArray.GetLength(0);
                Console.WriteLine("Average mark of subject {0}: {1}", i + 1, avg[i] / theArray.GetLength(0));
            }
            Console.WriteLine();
            Console.WriteLine("Average of total marks: {0}", avgOfTotalMarks / theArray.GetLength(1));
        }
    }
}
