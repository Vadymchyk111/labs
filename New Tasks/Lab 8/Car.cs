using System;

namespace Lab_8
{
    class Car
    {
        public string Model { get; }
        public string Color { get; }
        public int Speed { get; }
        public int Year { get; }

        public Car(string model, string color, int speed, int year)
        {
            Model = model;
            Color = color;
            Speed = speed;
            Year = year;
        }
        public void PrintCar()
        {
            Console.WriteLine($"Модель: {Model}" +
                              $"\nЦвет: {Color}" +
                              $"\nСкорость: {Speed}" +
                              $"\nГод выпуска: {Year}\n");
        }
        public void UseCarForRide()
        {
            Console.WriteLine($"Используемая машина: {Model} цвет: {Color} год: {Year}");
        }
    }
}
