using System;

namespace Lab_10
{
    public static class Extensions
    {
        public static int Reverse(this int Value)
        {
            int reversed = 0;
            while (Value > 0)
            {
                int remainded = Value % 10;
                reversed = (reversed * 10) + remainded;
                Value = Value / 10;
            }
            return reversed;
        }
        public static string Reverse(this string word)
        {
            if (word.Length == 0) return word;
            return word[word.Length - 1] + Reverse(word.Substring(0, word.Length - 1));
        }
        public static string ReverseWith2orMore(this string word)
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
        public static double ReverseWith2orMore(this double value)
        {
            string stringValue = value.ToString();
            string reversedValue = ReverseWith2orMore(stringValue);
            return Double.Parse(reversedValue);
        }
        public static int[] ReverseArray(this int[] Arr)
        {
            int[] newArr = new int[Arr.Length];
            for (int i = 0, j = Arr.Length - 1; i < Arr.Length; i++, j--)
            {
                newArr[i] = Arr[j];
            }
            return newArr;
        }
        public static void ReversedPrint(this int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write(array[i] + " ");
        }
    }
}
