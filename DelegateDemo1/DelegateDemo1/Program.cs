using System;

namespace DelegateDemo1
{
    class Program
    {
        public delegate int Transform(int x);
        public static  int Square(int x) => x * x;

        public void Operation(int[] val,Transform t)
            {
            for (int i = 0; i < val.Length; i++)
            {
                val[i] = t(val[i]);
            }
            }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] val = {2,4,5 };
            p.Operation(val, Square);
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
                Console.WriteLine("Hello World!");
        }
    }
}
