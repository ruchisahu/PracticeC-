using System;
using System.Collections.Generic;

namespace GenericDemoTypesafety
{
    class Program
    {
        public static void Test()
        {
            var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            var genericList1 = new List<Coffee>();
            genericList1.Add(coffee1);
            genericList1.Add(coffee2);
            // This line causes a build error, as the argument is not of type Coffee.
            genericList1.Add(tea1);
            // The Sort method will work because the collection is guaranteed to be homogenous.
            genericList1.Sort();
            // The indexer returns objects of type Coffee, so there is no need to cast the return value.
            Coffee coffee3 = genericList1[1];

        }
        static void Main(string[] args)
        {
            Test();
            Console.WriteLine("Hello World!");
        }
    }
}
