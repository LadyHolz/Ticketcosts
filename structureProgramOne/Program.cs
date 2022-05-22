using System;

namespace structureProgramOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program 1
            The Applied Science Charities Team is organising a car washing event.  Five students are involved in car washing. 
            After the event has ended the Charities Team must tell the director of the school the total money that
            has been raised, and the average money raised by each of the five students.
            The program will ask the user to enter the money raised by each of the five students using a 
            loop to iterate five times.  It will then perform the calculations and display the output.
            */

            int total = 0;
            int student = 5;

            for (int i = 0; i < student; i++)
            {
                Console.WriteLine("How much have you raised: ");
                string studentTaking = Console.ReadLine();
                int intScore = Convert.ToInt32(studentTaking);
                total = total + intScore;

            }   
            Console.WriteLine("total raised: " + (total));
            Console.WriteLine("Average per student: " + (total/student));
        }
    }
}
