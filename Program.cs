using System;

namespace QuadraticEquation 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма для розв'язання квадратного рівняння ax^2+bx+c=0");
            Console.WriteLine("Виконав Побережний Роман Дмитрович, студент групи КН21-1");

            int a, b, c;
            
            while (true)
            {
                Console.Write("Введіть коефіцієнт a: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Некоректне значення. Будь ласка, введіть ціле число.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Введіть коефіцієнт b: ");
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Некоректне значення. Будь ласка, введіть ціле число.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Введіть коефіцієнт c: ");
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Некоректне значення. Будь ласка, введіть ціле число.");
                    continue;
                }
                break;
            }

            int D = b * b - 4 * a * c;

            Console.WriteLine($"Квадратне рівняння: {a}x^2 + {b}x + {c} = 0");
           
            Console.WriteLine($"Значення дискримінанту D = {D}");

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Рівняння має два різних корені: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Рівняння має один корінь: x = {x}");
            }
            else
            {
                Console.WriteLine("Рівняння не має дійсних коренів");
            }

            Console.ReadLine();
        }
    }
}
