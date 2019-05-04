using System;

namespace GenericDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<Coffee> clc = new CustomList<Coffee>;
            Coffee coffee1 = new Coffee();
            Coffee coffee2= new Coffee();
            clc.Add(coffee1);
            clc.Add(coffee2);
            Coffee firstcoffee = clc[0];



            Console.WriteLine("Hello World!");
        }
    }
}
