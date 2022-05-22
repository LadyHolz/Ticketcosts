using System;

namespace structProgFour
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int stations = 11;
            int sum = 0;
            for (int i = 1; i < stations; i++)
            {
                Console.WriteLine("Input the rainfall for a station" + " " + i + ":");
                string x = Console.ReadLine();
                int rain = Convert.ToInt32(x);
                
               sum += rain;
            }
            Console.WriteLine("Total:" + sum);
            Console.WriteLine("Average:" + (sum/10));




        }
        
        
        
    }
}
