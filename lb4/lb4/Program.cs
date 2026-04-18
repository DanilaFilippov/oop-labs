using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader("input.txt"));
            Console.SetOut(new StreamWriter("output.txt") { AutoFlush = true });
        
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            double[] arr = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            // ot 1000 do 5000
            double sumR = arr.Where(x => x > 1000 && x < 5000).Sum();
            // min max
            double sumMM = arr.Max() + arr.Min();
            // mod <= 1000
            var res = arr.Where(x => Math.Abs(x) <= 1000);

            Console.WriteLine($"1) Сумма в диапазоне (1000, 5000): {sumR}");
            Console.WriteLine($"2) Сумма Max + Min: {sumMM}");
            Console.Write("3) Элементы |x| <= 1000: ");
            Console.WriteLine(string.Join("; ", res.Select(x => x.ToString("F2"))));
        }
    }
}
