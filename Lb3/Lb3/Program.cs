using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            double z = 1.0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

                double num;
                if (i == 1)
                    num = 1;
                else if (i % 2 == 0)
                    num = Math.Pow(x, i - 1);
                else
                    num = Math.Pow(y, i - 1);

                double tmp = num / factorial;
                if (i % 2 == 0)
                    z -= tmp;
                else
                    z += tmp;
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Результат Z = {0:F6}", z);
            
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
