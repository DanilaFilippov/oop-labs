using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader("input.txt"));
            Console.SetOut(new StreamWriter("output.txt") { AutoFlush = true });

            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                double e = double.Parse(Console.ReadLine());

                if (a - c <= 0 || d - 8 * b <= 0 || 2 * b - c < 0 || a - Math.Sqrt(2 * b - c) < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    double s = (1.0 / Math.Sqrt(a - c)) + (1.0 / Math.Sqrt(d - 8 * b));
                    double k = Math.Sqrt(a - Math.Sqrt(2 * b - c));
                    Console.WriteLine("{0:F3}", s);
                    Console.WriteLine("{0:F3}", k);
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
