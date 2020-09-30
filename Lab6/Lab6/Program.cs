using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int task1 = 123;
            Console.Write("Task 1: ");
            Reverse(task1);
            string task2 = "ABC";
            Console.WriteLine("Task 2: " + Reverse(task2));
            string task3 = "123,456";
            Console.WriteLine("Task 3: " + ReverseWith2orMore(task3));
            string task4 = "АБВ,ГДЕ";
            Console.WriteLine("Task 4: " + ReverseWith2orMore(task4));
            Console.WriteLine("Task 5: Used");
            Console.WriteLine("Task 6: Used");
            Console.WriteLine("Task 7: Look at 8.1, 8.2 ");
            int[] task7 = { 2, 4, 6, 7, 4, 3, 7, 8, 5, 8 };
            ReverseArray(ref task7);
            Console.Write("Task 8.1: ");
            for (int i = 0; i < task7.Length; i++)
                Console.Write(" " + task7[i]);
            Console.WriteLine("");
            int[] task8 = { 6, 4, 3, 6, 8, 4, 2, 3, 6, 4 };
            int[] createdArr = null;
            ReverseArray(task8,out createdArr);
            Console.Write("Task 8.2: ");
            for (int i = 0; i < createdArr.Length; i++)
                Console.Write(" " + createdArr[i]);
        }
        static void Reverse(int Value)
        {
            int reverse_number = Value % 10;
            if (Value == 0)
            {
                Console.Write("\n");
                return;
            }
            Console.Write(reverse_number);
            Reverse(Value / 10);
        }
        static string Reverse(string word)
        {
            if (word.Length == 0) return word;
            return word[word.Length-1] + Reverse(word.Substring(0, word.Length - 1));
        }
        static string ReverseWith2orMore(string word)
        {
            string ReversedArray = string.Empty;
            var reverse_array = word.Split(',');
            for (int i = 0; i < reverse_array.Length - 1; i++)
            {
                ReversedArray += Reverse(reverse_array[i]) + ',';
            }
            ReversedArray += Reverse(reverse_array[reverse_array.Length - 1]);
            return ReversedArray;
        }
        static void ReverseArray(ref int[] Arr)
        {
            int[] newArr = new int[Arr.Length];
            for (int i = 0,j = Arr.Length - 1;i<Arr.Length;i++,j--)
            {
                newArr[i] = Arr[j];
            }
            Arr = newArr;
        }
        static void ReverseArray(int[] Arr, out int[] createdArr)
        {
            createdArr = new int[Arr.Length];
            for (int i = 0, j = Arr.Length - 1; i < Arr.Length; i++, j--)
            {
                createdArr[i] = Arr[j];
            }
        }
    }
}
