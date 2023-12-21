using System.Runtime.CompilerServices;
namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Дана функция: sin2x - lnx = 0");
            Console.WriteLine("Введите значение a (от):");
            Console.ForegroundColor = ConsoleColor.Cyan;
            double a = Convert.ToInt32(Console.ReadLine()); //y1 -10
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите значение b (до):");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int b = Convert.ToInt32(Console.ReadLine()); //y2 10
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите значение h (шаг):");
            Console.ForegroundColor = ConsoleColor.Cyan;
            double h = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите значение e (эпсилон):");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели: \nОтрезок от {a} до {b} \nШаг {h} \nЭпсилон {e}.");
            double x1 = a;
            double x2 = x1 + h;
            double y1 = Math.Sin(2 * x1) - Math.Log10(x1);
            Console.WriteLine($"Вы получили: \nЗначение х1: {x1} \nЗначение х2: {x2} \nЗначение у1: {y1}.");
            if (x2 < b)
            {
                double y2 = Math.Sin(2 * x2) - Math.Log10(x2);
                Console.WriteLine($"Вы получили: \nЗначение y2: {y2}.");
                double yy = y1 * y2;
                if (yy < 0)
                {
                    Console.WriteLine($"Вы получили: \nЗначение х1: {x1} \nЗначение х2: {x2}.");
                    x1 = x2;
                    x2 = x1 + h;
                    y1 = y2;
                }
                else
                {
                    x1 = x2;
                    x2 = x1 + h;
                    y1 = y2;
                }
            }
            else
            {
                Console.Clear();
            }
        }
    }
}