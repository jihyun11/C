namespace Test2
{
    delegate void DelegateFunc(double i);
    delegate void DeleFunc(double i); //MethodC에 대한 delegate 선언
    class Base
    {
        private int a, b;

        public Base(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        virtual public void MethodA()
        {
            Console.WriteLine("Base MethodA" + a);
        }

        virtual public void MethodB()
        {
            Console.WriteLine("Base MethodB" + b);
        }

        public void MethodC(double d)
        {
            Console.WriteLine("Base MethodC, d = {0:.00}",d); //반올림까지 해 준 값이 소수점 두자리 수로 반환.
        }

    }

    class DerivedClass : BaseClass
    {
        private int c;

        //인덱서
        private string[] values = new string[5];
        public string this[int index]
        {
            get {return values [index];}
            set {values[index] = value;}
        }

        //상속받은 클래스의 생성자
        public DerivedClass(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }

        new public void MethodA()
        {
            Console.WriteLine("Drived MethodA" + c);
        }

        override public void MethodB()
        {
            Console.WriteLine("Drived MethodB" + c);
        }

        new public void MethodC(double d)
        {
            Console.WriteLine("Drived MethodC, d = {0:.00}",d; //반올림까지 해 준 값이 소수점 두자리 수로 반환.
        }
    }

    internal Program
    {
        static void Main(string[] args)
        {
            Base b = new DerivedClass(1, 2, 3);
            b.MethodA(); //Base MethodA 1
            b.MethodB(); //Derived MethodB 3
            b.MethodC(Math.PI); //Base MethodC 3.1

            Base bb = new DerivedClass(1, 2, 3);
            DelegateFunc d = new DelegateFunc(bb.MethodC)//delegate 사용하기 위한 등록
            d(Math.PI) //delegate를 사용해 MethodC를 호출

            DeleFunc df = new DeleFunc(bb.MethodA);
            df += new DeleFunc(bb.MethodB);
            df();
        }
    }
}