using System;

namespace static1
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightInKilos = 80;
            double weightInPounds = Conversions.KilosToPounds(weightInKilos);
            Console.WriteLine("Hello World!");
        }
    }
}
