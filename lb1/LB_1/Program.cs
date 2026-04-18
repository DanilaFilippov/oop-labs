using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string lab = "Лабораторная работа №1. Изучение основ языка C#";
            string name = "Филиппов Данила Валерьевич";
            string group = "ИСиТ-3-24/1 (09.03.02)";
            string birthDate = "24.09.2001";
            string city = "Ставрополь";
            string subject = "Информатика";
            string hobbies = "Pawn";

            Console.WriteLine("==================================================");
            Console.WriteLine(lab);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"ФИО студента: {name}");
            Console.WriteLine($"Группа и шифр: {group}");
            Console.WriteLine($"Дата рождения: {birthDate}");
            Console.WriteLine($"Место жительства: {city}");
            Console.WriteLine($"Любимый предмет: {subject}");
            Console.WriteLine($"Хобби и интересы: {hobbies}");
            Console.WriteLine("==================================================\n");

            double rx = 5.0, z = 3.0, f1 = 2.0, Et = 14.0;

            double ch = rx * z + z * f1 - (f1 + Et) / rx;

            Console.WriteLine("\nРезультаты вычислений (Вариант 18):");
            Console.WriteLine($"Исходные данные: rx={rx}, z={z}, f1={f1}, Et={Et}");
            Console.WriteLine($"Результат: ch = {ch:F4}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
