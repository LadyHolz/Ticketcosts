using System;

namespace structProgTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program 2
            Write a program which will read in 10 characters.  
            The program will then print out how many “A”s there were.*/

            int characters = 10;
            int count = 0;
           

            for (int i = 0; i < characters; i++)
            {

                Console.Write("Input a symbol: ");
                char symbol = Convert.ToChar(Console.ReadLine());
                

                if (symbol == 'A' | symbol == 'a')
                {
                    count++;
                }
     
            }
            Console.WriteLine("Total 'A's: " + count);

        }
    }
}
