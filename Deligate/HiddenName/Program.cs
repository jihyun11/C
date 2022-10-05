namespace HiddenName
{
    abstract class AAA
    {
        protected int a = 1;
        protected int b = 2;

        virtual public void MethodA()
        {
            Console.WriteLine("AAA-AAA");
        }

        virtual public void MethodB()
        {
            Console.WriteLine("AAA-BBB");
        }

        virtual public void MethodC()
        {
            Console.WriteLine("AAA-CCC");
        }

        public abstract void testA()
        {

        }
    }


    class BBB : AAA
    {
        new int a = 3; //위에 같은 이름의 변수가 있어서 new 키워드로 새로 만들어졌다는 걸 알려줌.
        new double b = 4.5;

        new public void MethodA()
        {
            Console.WriteLine("BBB-AAA");
        }

        override public void MethodB()
        {
            Console.WriteLine("BBB-BBB");
        }

        new public void MethodC()
        {
            Console.WriteLine("BBB-CCC");
        }

        public void Output()
        {
            Console.WriteLine("{0} {1}", a, b);
        }

        public override void testA()
        {
            throw new NotImplementedException();
            Console.WriteLine("TEST");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AAA b = new BBB();
            b.MethodA();
            b.MethodB();
            b.MethodC();
        } //동적바인딩은 override와 new가 적힌 메소드에서만 발생한다. ovverride를 하기 위해서는 반드시 virtual이 붙은 메소드가 필요.
    }
}
// 호출관계 이해하기 -> 중간고사 출제. (상속에 상속 ... etc.)
