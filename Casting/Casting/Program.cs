using System;
using System.Collections;

namespace Casting
{
    struct Point
    {
        public int x, y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Point p;
            for (int i = 0; i < 10; i++)
            {
                p.x = p.y = i;
                a.Add(p);
            }
            Console.WriteLine(a);

            Console.WriteLine("Hello World!");
        }
    }
}
