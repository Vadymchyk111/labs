using System;
using System.Collections.Generic;

namespace Lab_8
{
    class Garage
    {
        private List<Car> Cars { get; }

        public Garage()
        {
            Cars = new List<Car>();
        }
        public void PrintCarsInside()
        {
            if (Cars.Count <= 0)
                Console.WriteLine("Гараж пуст.");
            else
            {
                for (int i = 0; i < Cars.Count; i++)
                {
                    Console.WriteLine($"Машина #{i + 1}");
                    Cars[i].PrintCar();
                }
            }
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RemoveCar(Car carToRemove)
        {
            Cars.Remove(carToRemove);
        }
        public List<Car> FindCars(string model, string color, int speed, int year)
        {
            List<Car> candidates = new List<Car>();
            foreach (var car in Cars)
            {
                if (model != "0" && car.Model != model)
                    continue;
                if (color != "0" && car.Color != color)
                    continue;
                if (speed != 0 && car.Speed != speed)
                    continue;
                if (year != 0 && car.Year != year)
                    continue;

                candidates.Add(car);
            }
            return candidates;
        }
    }
}
