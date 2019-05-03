using System;

namespace dependencyInjection1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogin businesslogic = new BusinessLogin();
            businesslogic.PrecessData();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
