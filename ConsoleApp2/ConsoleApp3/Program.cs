using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Figure = new int[2];
            Console.WriteLine("Поместите фигуру в координаты от 1 до 8, X:  Y: ");
            do
            {
                Figure[0] = int.Parse(Console.ReadLine());
                Figure[1] = int.Parse(Console.ReadLine());
                if (Figure[0] < 0 || Figure[0] > 8 || Figure[1] < 0 || Figure[1] > 8)
                    Console.WriteLine("Введите координаты от 1 до 8");
            } while (Figure[0]<0||Figure[0]>8|| Figure[1] < 0 || Figure[1] > 8);
            int[] Piece_move = new int[2];
            Console.WriteLine("Введите точку в которую желаете походить X:  Y: ");
            do
            {
                Piece_move[0] = int.Parse(Console.ReadLine());
                Piece_move[1] = int.Parse(Console.ReadLine());
                if (Piece_move[0] < 0 || Piece_move[0] > 8 || Piece_move[1] < 0 || Piece_move[1] > 8)
                    Console.WriteLine("Введите координаты от 1 до 8");
            } while (Piece_move[0] < 0 || Piece_move[0] > 8 || Piece_move[1] < 0 || Piece_move[1] > 8);
            if ((Piece_move[0]==Figure[0] && Piece_move[1] != Figure[1])|| (Piece_move[1] == Figure[1] && Piece_move[0] != Figure[0]))
            {
                Console.WriteLine("TRUE");
            }
            else Console.WriteLine("FALSE");
        }
    }
}
