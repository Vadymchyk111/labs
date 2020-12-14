using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество ваших чисел: ");
            int amount;
            while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.Write("Некорректный ввод. Допускаются только значения больше 0. Попробуйте снова: ");
            }

            List<double> list = new List<double>(amount);

            for (int i = 0; i < amount; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                double input;
                input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            Console.WriteLine("Введите число с которым сравниваете: ");
            double num = double.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                if (list[i] == num)
                    Console.WriteLine("Число под индексом "+(i+1)+ " равно "+num);
            }
            double[] array = list.ToArray();
        }

    }
}
