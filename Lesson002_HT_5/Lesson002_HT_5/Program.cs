using System;

namespace Lesson002_HT_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double pi = 3.141;
            double h = 3;
            double r = 5.2;
            double V = pi * Math.Pow(r, 2) * h;
            double S = 2 * pi * r * (r + h);
            Console.WriteLine("V = " + V + " " + "S = " + S);
        }
    }
}
