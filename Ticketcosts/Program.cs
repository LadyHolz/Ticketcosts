using System;

namespace Ticketcosts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter: E for edinburgh, L for London, D for Durham, Y for York");
            string destination = Console.ReadLine();    
            char charDestination = char.Parse(destination);

            switch (charDestination)
            {
                case 'E':
                    Console.WriteLine("Ticket price for Edinburgh is £50.00");
                    break;
                case 'L':
                    Console.WriteLine("Ticket price for London is £65.50");
                    break;
                case 'D':
                    Console.WriteLine("Ticket price for Durham is £17.50");
                    break;
                case 'Y':
                    Console.WriteLine("Ticket price for York is £28.00");
                    break;
                default:
                    Console.WriteLine("Invalid Destination");
                    break;
            }       
        }
    }
}
