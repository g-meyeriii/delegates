using System;

namespace Delegates
{
    class Program
    {
        //public delegate double PerformCalculation(double x, double y);

        //public static double Addition(double a, double b)
        //{
        //    Console.WriteLine("a+b is :   " + (a+b));
        //    return a + b;
        //}
        //public static double Division(double a, double b)
        //{
        //    Console.WriteLine("a/b is :   " + (a / b));
        //    return a / b;
        //}
        //public static double Subtraction(double a, double b)
        //{
        //    Console.WriteLine("a-b is :   " + (a - b));
        //    return a - b;
        //}
        public delegate string GetTextDelegate(string name);

        static void Main(string[] args)
        {
            // Creating an anonymous method or inline delegate
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };
            Console.WriteLine(getTextDelegate("Sophie"));
            Display(getTextDelegate);

            //PerformCalculation getSum = Addition;
            ////getSum(5.0, 5.0);
            //PerformCalculation getQuotient = Division;
            ////getQuotient(5.0, 5.0);

            //PerformCalculation multiCalc = getSum + getQuotient;
            //multiCalc += Subtraction;
            //multiCalc -= getSum;
            //multiCalc(3.2, 3.2);



        }
        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World"));
        }
        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
