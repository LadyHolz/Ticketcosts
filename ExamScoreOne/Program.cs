using System;

namespace ExamScoreOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int maxStudent = 10;

            for (int loop = 0; loop < maxStudent; loop++)
            {
                Console.WriteLine("Input your score: ");
                string strScore = Console.ReadLine();
                int intScore = Convert.ToInt32(strScore);
                total = intScore + total;

                if (intScore >= 50 && intScore <= 100)
                {
                    Console.WriteLine("Pass");
                }
                else if (intScore >= 0 && intScore <= 49)
                {
                    Console.WriteLine("Resit");
                }
                else
                {
                    Console.WriteLine("enter a value between 0-100 ");
                }
            }

            Console.WriteLine("Average: " + (total/maxStudent));

        }
    }
}
