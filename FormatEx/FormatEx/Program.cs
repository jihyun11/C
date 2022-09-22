// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace FormatEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0, -5}, {1, 5}, {2, 5}", 1.2, 1.2, 123.45);
            Console.WriteLine("1234567891234567891234567890");
            double d = Math.PI;
            Console.WriteLine("{0:f3}, {1:0.00#}", d, d);
            Console.WriteLine("{0:c}, {1:E}", d, d);
            Console.WriteLine("{0:X}, {1:x}", 254, 254);
        }
    }
}

