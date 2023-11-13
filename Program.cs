using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main()
        {          
                // Create a jagged array called studentScores to store scores of three students
                int[][] studentScores = new int[3][];

                studentScores[0] = new int[] { 85, 92, 78 };
                studentScores[1] = new int[] { 90, 87, 93, 89 };
                studentScores[2] = new int[] { 76, 88 };

                // Print scores of each student
                Console.WriteLine("Scores of Each Student:");
                for (int i = 0; i < studentScores.Length; i++)
                {
                    Console.Write($"Student {i + 1}: ");
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        Console.Write(studentScores[i][j] + " ");
                    }
                Console.WriteLine();
            }

            Console.WriteLine();


            // Calculate and print the average score for each student
            Console.WriteLine("Average Score for Each Student:");
                for (int i = 0; i < studentScores.Length; i++)
                {
                    double average = CalculateAverage(studentScores[i]);
                    Console.WriteLine($"Student {i + 1}: {average:F2}");
                }

                Console.WriteLine();

            // Calculate and print the average score for all students
            double overallAverage = CalculateOverallAverage(studentScores);
                Console.WriteLine($"Overall Average Score: {overallAverage:F2}");
            Console.ReadKey();
            }
                  
            //calculate the average of an array of integers
            static double CalculateAverage(int[] scores)
            {
                if (scores.Length == 0)
                {
                    return 0; 
                }

                int sum = 0;
                foreach (int score in scores)
                {
                    sum += score;
                }

                return (double)sum / scores.Length;
            }

            //calculate the overall average of jagged array scores
            static double CalculateOverallAverage(int[][] studentScores)
            {
                int totalScores = 0;
                int totalStudents = studentScores.Length;

                foreach (int[] scores in studentScores)
                {
                totalScores += scores.Length > 0 ? (int)CalculateAverage(scores) : 0;
                }

                return totalStudents > 0 ? (double)totalScores / totalStudents : 0;
        }
    }

    }