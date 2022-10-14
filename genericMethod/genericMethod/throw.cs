using System;
namespace genericMethod
{
    class Program
	{
		static void throw(int age)
		{
			if (age< 10) {
				Console.WriteLine("age: {0}", age);
		} else throw new Exception("age가 10보다 큽니다.");
	}
} static void Main(string[] args)
{
	try
    {
		throw (1);
		throw (10);
    }
	catch (Exception e)
    {
		Console.WriteLine(e.Message);
    }
}

