using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Write start index:");
            int Start_Index = int.Parse(Console.ReadLine());
            Console.WriteLine("Write finish index:");
            int Finish_Index = int.Parse(Console.ReadLine());
            double Sum = 0;
            if (Start_Index <= Finish_Index && Start_Index >= 0)
            {
                for (int k = Start_Index; k < Finish_Index; k++)
                {
                    double temp;
                    temp = (Math.Pow(k, 2) + Math.Pow(-1, k) * (k - 1)) / (Math.Pow(k, 2) + 1);
                    Sum = Sum + temp;
                }
                Console.WriteLine("Sum = " + Sum);
            }
            else
                Console.WriteLine("Invalid value/values");
        }
    }
}
