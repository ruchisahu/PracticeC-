using System;

namespace interfacedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.AddPoints(4);
            c.AddPoints(3);
            Console.WriteLine(c.TotalPoints);
            Console.WriteLine("Hello World!");
        }
    }
}
