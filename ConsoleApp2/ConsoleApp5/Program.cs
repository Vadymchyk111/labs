using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива N*N, N: ");
            int N = int.Parse(Console.ReadLine());
            float[,] Array = new float[N, N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Array[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Array[i, j]+ "\t");
                }
                Console.WriteLine();
            }
            /*for (int j  = 0; j < (N/2); j++)
            {
                for (int i  = 0; i < N; i++)
                {
                    Array[(N - 1 - j), i] = Array[j, i];
                }
            }*/
            /*for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < (N / 2); j++)
                {
                    Array[i, (N - 1 - j)] = Array[i, j];
                }
            }*/
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Array[j, i] = Array[i, j];
                }
            }

            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
