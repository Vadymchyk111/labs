using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Напряжение - U: ");
            double U = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление проводника - R: ");
            double R = Double.Parse(Console.ReadLine());
            double I = U / R;
            Console.WriteLine("Сила тока = " + I);
        }
    }
}
