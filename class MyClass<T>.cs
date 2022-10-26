#define PRINT

namespace  myClass
{


class MyClass<T>
{
    private T[] values;
    private int index;

    public MyClass(int len)
    {
        values = new T[len];
        index = 0;
    }

    public int Index
    {
        get {return index; }
        set {index = value; }
    }

    public void add(params T[] args) //params로 받으면 정해주지 않아도 임의의 개수를 받을 수 있다.
    {
        foreach (T item in args)
        {
            values[index++] = item;
        }
    }

    [Conditional("PRINT")] //조건부 어트리뷰트
    public void print()
    {
        foreach (T item in values)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        double? num1 = 10.0;

        if (num1.HasValue)
        {
            Console.WriteLine("num1 = " + num1.Vlaue;)
        }else
        {
            Console.WriteLine("num1 = null");
        }

        MyClass<Int32> mc = new MyClass<Int32>(10);
        mc.add(1, 2, 3, 4, 5, 6, 7);
        mc.add(10);
        mc.print();
    }
}

}