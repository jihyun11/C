using System.Collections.Generic;

namespace Classes
{
public class Color
    {
        public const int FULL = 0xFF;
        public const int EMPTY = 0x00F;

        private byte red, green, blue;
        private int fULL;
        private int eMPTY1;
        private int eMPTY2;
        public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);
        public static readonly Color blue = new Color(EMPTY, EMPTY, FULL);
        public static readonly Color green = new Color(EMPTY, FULL, EMPTY);

        public Color(byte red, byte blue, byte green)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }

        public void PrintColor(Color c)
        {
            Console.WriteLine("{0}, {1}, {2}", c.red, c.blue, c.green);
        }
    } 

    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine(Color.FULL);
            Color.PrintColor(Color.Red);
            
        }
    }
}
