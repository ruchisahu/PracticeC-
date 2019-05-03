using System;

namespace overatorOverloading2
{
    class ComplexNumber
    {
        double Re, Im;
        public ComplexNumber()
        {
        }
        public ComplexNumber(Double Real, Double Imagin)
        {
            Re = Real;
            Im = Imagin;

        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re+c2.Re, c1.Im+c2.Im);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re - c2.Re, c1.Im - c2.Im);
        }
        static void Main(string[] args)
        {
            ComplexNumber number1 = new ComplexNumber(3, 4);
            ComplexNumber number2 = new ComplexNumber(1, 2);
            ComplexNumber number3 = new ComplexNumber();
            ComplexNumber number4 = new ComplexNumber();
            number3 = number1 + number2;
            number4 = number1 - number2;
            Console.WriteLine(number3.Im);
            Console.WriteLine(number3.Re);


            Console.WriteLine(number4.Im);
            Console.WriteLine(number4.Re);
            Console.WriteLine("Hello World!");
        }
    }
}
