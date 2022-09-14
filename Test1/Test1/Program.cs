// See https://aka.ms/new-console-template for more information

namespace Test1
{
    internal class Program
    {
        static void Main(string[]args)
        {
            double d = 0d;
            decimal m = 0m;

            for (int i = 0; i < 1000; i++)
            {
                d += 0.10d;
                m += 0.10m;
            
            }
            Console.WriteLine(d);
            Console.WriteLine(m);
        }
    }
}
