namespace Delegate
{
    delegate void dele();
    delegate void d2(int i);

    class AAA
    {
        public void M1()
        {
            Console.WriteLine("AAA.M1()");
        }
        public void M2(int a)
        {
            Console.WriteLine("AAA.M2()" + a);
        }
        public void M3()
        {
            Console.WriteLine("AAA.M3()");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AAA a = new AAA();
            dele d1 = new dele(a.M1); // m1 이 등록됨
            d1 += new dele(a.M3);
            d1(); //델리게이트로 d1을 호출 m3이 있으면 두 개를 한번에 같이 부를 수 있음 (매개변수 모양 같은 애들끼리)



            d2 dd = new d2(a.M2);
            dd(10);
        }
    }
}

