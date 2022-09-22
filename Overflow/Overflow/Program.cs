// See https://aka.ms/new-console-template for more information
// CS1002.cs 
Console.WriteLine("Hello, World!");

namespace Overflow
{
    class Program
    {
        static void Main(String[] agrs)
        {
            int i, max = int.MaxValue

            try
            {
                checked
                {
                    i = max + 1;
                }
               
                Console.WriteLine(i);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("예외" + e);

            }
        }
    }
}

