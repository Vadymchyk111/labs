using System;

namespace Lab_10
{
    class Program
    {
        static void Main()
        {
            int task1 = 123;
            Console.WriteLine("Task 1: " + task1.Reverse());

            string task2 = "ABC";
            Console.WriteLine("Task 2: " + task2.ReverseWith2orMore());

            string task3 = "123,456";
            Console.WriteLine("Task 3: " + task3.ReverseWith2orMore());

            string task4 = "АБВ,ГДЕ";
            Console.WriteLine("Task 4: " + task4.ReverseWith2orMore());

            Console.Write("Task 7: ");
            int[] task7 = { 2, 4, 6, 7, 4, 3, 7, 8, 5, 8 };
            var reversedArray = task7.ReverseArray();
            for (int i = 0; i < reversedArray.Length; i++)
                Console.Write(" " + reversedArray[i]);
            Console.WriteLine();

            Console.Write("Task of variant 5: ");
            int[] array = new[] {1, 2, 3, 4, 5};
            array.ReversedPrint();

            Console.ReadKey();
        }
    }
}