namespace GenericMethod
{
    class Program
    {
        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            temp = x;
            x = y;
            y = temp;
        }
    } static void Main(string[] args)
    {
        int a = 1, b = 2; double c = 1.5, double d = 2.5;
        Program p = new Program();
        
        Swap<int>(ref a, ref b);
        Console.WriteLine("{0}, {1}", a, b);
    }
}

