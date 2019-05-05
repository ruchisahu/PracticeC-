using System;

namespace InheritanceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Asset2 asset2 = new Asset2();
            asset2.Price();
            asset2.Quantity();

            Asset1 a = asset2;  //upcast;
            a.Price();

            Asset2 a2 = (Asset2)a;   //downcast
            Console.WriteLine("Hello World!");
        }
    }
}
