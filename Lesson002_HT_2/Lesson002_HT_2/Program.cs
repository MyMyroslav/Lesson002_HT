using System;

namespace Lesson002_HT_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            {
                x += y - x++ * z;
                Console.WriteLine("x = " + x);
            }
            {
                z = --x - y * 5;
                Console.WriteLine("z = " + z);
            }
            {
                y /= x + 5 % z;
                Console.WriteLine("y = " + y);
            }
            {
                z = x++ + y * 5;
                Console.WriteLine("z = " + z);
            }
            {
                x = y - x++ * z;
                Console.WriteLine("x = " + x);
            }


        }
    }
}
