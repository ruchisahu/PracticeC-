using System;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {        
            int? TicketOnsale = 100;
            int TicketAvaible = TicketOnsale?? 0; //null colision operator
            
                Console.WriteLine(TicketAvaible);
         
            Console.WriteLine("Hello World!");
        }
    }
}
