using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8
{
    class Program
    {
        static void Main()
        {
            Garage garage = new Garage();

            while (true)
            {
                Console.WriteLine(
                    "Меню гаража\n" +
                    "Выберите действие\n" +
                    "[0]. Выйти из меню\n" +
                    "[1]. Добавить машину\n" +
                    "[2]. Удалить машину\n" +
                    "[3]. Покататься на машине\n" +
                    "[4]. Посмотреть все машины в гараже");

                int choose;
                while (!int.TryParse(Console.ReadLine(), out choose) || choose < 0 || choose > 4)
                    Console.Write("Некорректный ввод. Попробуйте снова: ");

                if (choose == 0)
                {
                    return;
                }
                else if (choose == 1)
                {
                    string name = null;
                    string color = null;
                    int speed;
                    int year;

                    Console.WriteLine("Введите характеристики новой машины: ");

                    Console.Write("Введите название: ");
                    while (string.IsNullOrEmpty(name))
                    {
                        name = Console.ReadLine();
                        if (!string.IsNullOrEmpty(name))
                            break;
                        Console.Write("Ввод неправильный, повторите попытку: ");
                    }

                    Console.Write("Введите цвет: ");
                    while (string.IsNullOrEmpty(color))
                    {
                        color = Console.ReadLine();
                        if (!string.IsNullOrEmpty(color))
                            break;
                        Console.Write("Ввод неправильный, повторите попытку: ");
                    }

                    Console.Write("Введите скорость: ");
                    while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
                        Console.Write("Ввод неправильный, повторите попытку: ");

                    Console.Write("Введите год выпуска: ");
                    while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
                        Console.Write("Ввод неправильный, повторите попытку: ");

                    // Добавление
                    Car operatingCar = new Car(name, color, speed, year);
                    garage.AddCar(operatingCar);
                    Console.WriteLine("Машина добавлена в гараж.");
                }
                else if (choose == 2)
                {
                    string name = null;
                    string color = null;
                    int speed;
                    int year;

                    Console.WriteLine("Выберите машину по критериям (\"0\" - пропуск поля): ");

                    Console.Write("Введите название: ");
                    while (string.IsNullOrEmpty(name))
                    {
                        name = Console.ReadLine();
                        if (!string.IsNullOrEmpty(name))
                            break;
                        Console.Write("Ввод неправильный, повторите попытку: ");
                    }

                    Console.Write("Введите цвет: ");
                    while (string.IsNullOrEmpty(color))
                    {
                        color = Console.ReadLine();
                        if (!string.IsNullOrEmpty(color))
                            break;
                        Console.Write("Ввод неправильный, повторите попытку: ");
                    }

                    Console.Write("Введите скорость: ");
                    while (!int.TryParse(Console.ReadLine(), out speed) || speed < 0)
                        Console.Write("Ввод неправильный, повторите попытку: ");

                    Console.Write("Введите год выпуска: ");
                    while (!int.TryParse(Console.ReadLine(), out year) || year < 0)
                        Console.Write("Ввод неправильный, повторите попытку: ");

                    List<Car> possibleCars = garage.FindCars(name, color, speed, year);
                    if (possibleCars.Count > 0)
                    {
                        Console.WriteLine("Подходящие машины в гараже: ");
                        for (int i = 0; i < possibleCars.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} машина:\n");
                            possibleCars[i].PrintCar();
                        }

                        if (possibleCars.Count > 1)
                        {
                            Console.WriteLine("Найдено несколько машин по введенным критериям. Выберите номер машины, которую хотите удалить из гаража: ");
                            int choosenCar;
                            while (!int.TryParse(Console.ReadLine(), out choosenCar) || choosenCar <= 0 || choosenCar > possibleCars.Count)
                                Console.Write("Ввод неправильный, повторите попытку: ");
                            garage.RemoveCar(possibleCars[choosenCar - 1]);
                        }
                        else
                            garage.RemoveCar(possibleCars[0]);

                        Console.WriteLine("Машина убрана из гаража.");
                    }
                    else
                        Console.WriteLine("В гараже нет подходящих машин. \n");
                }
                else if (choose == 3)
                {
                    string name = null;
                    string color = null;
                    int speed;
                    int year;

                    Console.WriteLine("Выберите машину по критериям (\"0\" - пропуск поля): ");

                    Console.Write("Введите название: ");
                    while (string.IsNullOrEmpty(name))
                    {
                        name = Console.ReadLine();
                        if (!string.IsNullOrEmpty(name))
                            break;
                        Console.Write("Ввод неправильный, повторите попытку: ");
                    }

                    Console.Write("Введите цвет: ");
                    while (string.IsNullOrEmpty(color))
                    {
                        color = Console.ReadLine();
                        if (!string.IsNullOrEmpty(color))
                            break;
                        Console.Write("Ввод неправильный, повторите попытку: ");
                    }

                    Console.Write("Введите скорость: ");
                    while (!int.TryParse(Console.ReadLine(), out speed) || speed < 0)
                        Console.Write("Ввод неправильный, повторите попытку: ");

                    Console.Write("Введите год выпуска: ");
                    while (!int.TryParse(Console.ReadLine(), out year) || year < 0)
                        Console.Write("Ввод неправильный, повторите попытку: ");

                    List<Car> possibleCars = garage.FindCars(name, color, speed, year);
                    if (possibleCars.Count > 0)
                    {
                        Console.WriteLine("Подходящие машины в гараже: ");
                        for (int i = 0; i < possibleCars.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} машина:\n");
                            possibleCars[i].PrintCar();
                        }

                        if (possibleCars.Count > 1)
                        {
                            Console.WriteLine("Найдено несколько машин по введенным критериям. Выберите номер машины, на которой хотите прокатиться: ");
                            int choosenCar;
                            while (!int.TryParse(Console.ReadLine(), out choosenCar) || choosenCar <= 0 || choosenCar > possibleCars.Count)
                                Console.Write("Ввод неправильный, повторите попытку: ");
                            possibleCars[choosenCar - 1].UseCarForRide();
                        }
                        else
                            possibleCars[0].UseCarForRide();
                    }
                    else
                        Console.WriteLine("В гараже нет подходящих машин. \n");
                }
                else
                {
                    garage.PrintCarsInside();
                }
                Console.WriteLine();
            }
        }
    }
}
