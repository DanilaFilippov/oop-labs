using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader("input.txt"));
            Console.SetOut(new StreamWriter("output.txt") { AutoFlush = true });
            try
            {
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                int[,] matrix = new int[m, n];
                Random rand = new Random();

                double sum = 0;
                int count = 0;

                Console.WriteLine("1) Исходная матрица:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = rand.Next(-1000, 1001);
                        Console.Write($"{matrix[i, j],7}");
                        if (matrix[i, j] % 2 == 0)
                        {
                            sum += matrix[i, j];
                            count++;
                        }
                    }
                    Console.WriteLine();
                }
                double avg = count > 0 ? sum / count : 0;
                Console.WriteLine($"\n2) Среднее арифметическое четных элементов: {avg:F2}");

                Console.WriteLine("\n3) Модифицированная матрица:");
                for(int i = 0; i < m;i++)
                {
                    for(int j = 0;j < n; j++)
                    {
                        Console.Write($"{(matrix[i, j] > avg ? 'B' : 's'),5}");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
