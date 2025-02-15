﻿using System;
using System.Collections.Generic;
using System.IO;

namespace GradingStudents
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    result.Add(grade);
                }
                else
                {
                    int nextMultipleOfFive = ((grade / 5) + 1) * 5;
                    if (nextMultipleOfFive - grade < 3)
                    {
                        result.Add(nextMultipleOfFive);
                    }
                    else
                    {
                        result.Add(grade);
                    }
                }
            }
            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
