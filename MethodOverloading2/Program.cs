using System;

namespace MethodOverloading2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Add(int num1, int num2)
        { return num1 + num2; }
        public static decimal Add(decimal num1, decimal num2)
        { return decimal.Add(num1, num2); }
        public static string Add(int num1, int num2, bool mybool)
        {
            var sum = num1 + num2;
            if (mybool is true && sum == 1)
            { return $"{sum} dollar"; }
            else
            { return $"{sum} dollars"; }





        }
    }
}
