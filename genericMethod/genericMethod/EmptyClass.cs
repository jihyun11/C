using System;
namespace genericMethod
{
    public class EmptyClass
    {
        public EmptyClass()

        {
            var sheeps = new bool[] { true, false, true };
            int result = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
    }


