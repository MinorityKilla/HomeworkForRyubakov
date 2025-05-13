using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, res;
                string c;
                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знак для решения: ");
                c = Console.ReadLine();
                if (c == "+")
                {
                    res = a + b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "-")
                {
                    res = a - b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "*")
                {
                    res = a * b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "/")
                {
                    res = a / b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "%")
                {
                    res = a / b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "&")
                {
                    res = a & b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "|")
                {
                    res = a | b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "^")
                {
                    res = a ^ b;
                    Console.Write($"Результат = {res}");
                }
                else
                {
                    Console.WriteLine("Некоректное значение!");
                }
            }
            catch
            {
                Console.WriteLine("Некоректное значение!");
            }
            Console.ReadKey();

        }

    }
}
