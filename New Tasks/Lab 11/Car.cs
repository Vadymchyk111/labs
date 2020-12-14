using System;

namespace Lab_11
{
    class Car
    {
        public bool WheelAlignment { get; set; }
        public bool Paint { get; set; }
        public bool Oil { get; set; }
        public bool FullInspect { get; set; }
        public bool Wheels { get; set; }
        public bool Body { get; set; }
        public void PrintCatStatus()
        {
            Console.WriteLine($"Развал-схождение -- {WheelAlignment}" +
                              $"\nПокраска -- {Paint}" +
                              $"\nЗамена масла -- {Oil}" +
                              $"\nПолный техосмотр -- {FullInspect}" +
                              $"\nЗамена колес -- {Wheels}" +
                              $"\nРемонт кузова -- {Body}");
        }
    }
}
