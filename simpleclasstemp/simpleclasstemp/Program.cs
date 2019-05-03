using System;

namespace simpleclasstemp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiating a Class
            DrinksMachine dm1 = new DrinksMachine();

            // Using Object Members
            var dm = new DrinksMachine();
            dm.Make = "Fourth Coffee";
            dm.Model = "Beancrusher 3000";
            // dm.Age = 2;
            dm.MakeEspresso();
            Console.WriteLine("Hello World!");
        }

    }
}
