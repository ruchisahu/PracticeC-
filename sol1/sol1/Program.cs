using System;

namespace sol1
{
    interface IPerson
    {
        void Name();
        
    }
  
    class Student : IPerson
    {
        public void Name()
        {
            Console.WriteLine("hello");
        }
    }

   
    abstract class absClass
    {
        //A Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public virtual int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * 2;
        }
    }

    class absDerived : absClass
    {
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Student s = new Student();
            s.Name();
            Console.WriteLine("Hello World!");

            absDerived d = new absDerived();
            d.AddTwoNumbers(2, 2);
            Console.WriteLine(d.MultiplyTwoNumbers(3,4));
            Console.WriteLine("Hello World!");
        }
    }
}
