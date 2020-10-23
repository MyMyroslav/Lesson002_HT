using System;

namespace Lesson002_HT_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double pi = 3.141;
            double r = 2;
            double res = pi * Math.Pow(r, 2);
            Console.WriteLine("PR^2 = " + res);
        }
    }
}
