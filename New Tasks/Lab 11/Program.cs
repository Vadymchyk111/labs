using System;

namespace Lab_11
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.PrintCatStatus();

            Service carService = new Service();
            Service.ServiceDelegate serviceTask = null;
            int choose;
            Console.WriteLine("Хотите заказать настройку развала-схождения? [1] да [2] нет");
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 2)
                Console.Write("Ввод неправильный, повторите попытку: ");
            if (choose == 1)
                serviceTask += carService.WheelAlignmentService;

            Console.WriteLine("Хотите заказать покраску? [1] да [2] нет");
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 2)
                Console.Write("Ввод неправильный, повторите попытку: ");
            if (choose == 1)
                serviceTask += carService.PaintService;

            Console.WriteLine("Хотите заказать замену масла? [1] да [2] нет");
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 2)
                Console.Write("Ввод неправильный, повторите попытку: ");
            if (choose == 1)
                serviceTask += carService.RefillOil;

            Console.WriteLine("Хотите заказать полный техосмотр? [1] да [2] нет");
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 2)
                Console.Write("Ввод неправильный, повторите попытку: ");
            if (choose == 1)
                serviceTask += carService.InspectCar;

            Console.WriteLine("Хотите заказать замену колес? [1] да [2] нет");
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 2)
                Console.Write("Ввод неправильный, повторите попытку: ");
            if (choose == 1)
                serviceTask += carService.ChangeWheels;

            Console.WriteLine("Хотите заказать ремонт кузова? [1] да [2] нет");
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 2)
                Console.Write("Ввод неправильный, повторите попытку: ");
            if (choose == 1)
                serviceTask += carService.BodyService;

            if (serviceTask != null)
            {
                serviceTask(car);
                Console.WriteLine("Машина прошла обслуживание СТО...");
                Console.WriteLine("Статус машины:");
                car.PrintCatStatus();
            }
            else Console.WriteLine("Сервисные работы не были проведены");

            Console.ReadKey();
        }
    }
}
