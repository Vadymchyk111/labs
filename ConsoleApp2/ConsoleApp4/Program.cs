using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите деиствительное число:");
            float Number = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите длинну массива:");
            int Array_Length = int.Parse(Console.ReadLine());
            float[] Array = new float[Array_Length]; 
            for(int current_element=0;current_element<Array_Length;current_element++)
            {
                Console.WriteLine("Введите елемент массива №"+ (current_element + 1));
                Array[current_element] = float.Parse(Console.ReadLine());
            }
            float MinVal= Math.Abs(Number - Array[0]),MaxVal= Math.Abs(Number - Array[0]);
            float NumMinVal = 1, NumMaxVal = 1 ;
            for (int current_element = 1; current_element < Array_Length; current_element++)
            {
                if (Math.Abs(Number - Array[current_element]) < MinVal)
                {
                    MinVal = Math.Abs((Number - Array[current_element]));
                    NumMinVal = current_element + 1;
                }
                if (Math.Abs(Number - Array[current_element]) > MaxVal)
                {
                    MaxVal = Math.Abs((Number - Array[current_element]));
                    NumMaxVal = current_element + 1;
                }
            }
            Console.WriteLine("Ближайший по значению елемент под номером:" + NumMinVal);
            Console.WriteLine("Наидальший по значению елемент под номером:" + NumMaxVal);
        }
    }
}
