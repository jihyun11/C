// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace NullableType
{
internal class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double num2 = 10.0;

            if (num1.HasValue)
            {
                Console.WriteLine("AAA");
            else
                {
                    Console.WriteLine("BBB");
                }
            if (num2.HasValue)
                {
                    Console.WriteLine("CCC");
                }
            else
                {
                    Console.WriteLine("DDD");
                }
            }
        }
    }
}
