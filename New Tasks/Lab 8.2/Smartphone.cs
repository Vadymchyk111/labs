using System;

namespace Lab_8._2
{
    class Smartphone : ColorDisplayPhone
    {
        public bool TouchScreen { get; set; }
        public int MaxTouchesCount { get; set; }
        public int CamerasCount { get; set; }

        public Smartphone(string phoneNumber, int screenWidth, int screenHeight,
            float screenSize, string phoneColor, int screenColorsQuantity, int maxTouchesCount, int camerasCount, string secondaryPhoneNumber = null)
            : base(phoneNumber, screenWidth, screenHeight, screenSize, phoneColor, screenColorsQuantity, secondaryPhoneNumber)
        {
            CamerasCount = camerasCount;
            TouchScreen = MaxTouchesCount > 0;
            MaxTouchesCount = maxTouchesCount;
        }
        public void TakePhoto()
        {
            if (CamerasCount <= 0)
                Console.WriteLine("У смартфона нет камер");
            else if (CamerasCount == 1)
                Console.WriteLine("Фото сделано");
            else
            {
                Console.Write("Выберите камеру для фото: ");
                int choosenCamera;
                while (!int.TryParse(Console.ReadLine(), out choosenCamera) || choosenCamera < 1 || choosenCamera > CamerasCount)
                    Console.Write("Неправильный ввод, попробуйте снова: ");

                Console.WriteLine($"Сделано фото с камеры {choosenCamera}");
            }
        }

        public void RecordVideo()
        {
            if (CamerasCount <= 0)
                Console.WriteLine("У смартфона нет камер");
            else if (CamerasCount == 1)
                Console.WriteLine("Видео снято");
            else if (CamerasCount > 1)
            {
                Console.Write("Выберите камеру для видео: ");
                int choosenCamera;
                while (!int.TryParse(Console.ReadLine(), out choosenCamera) || choosenCamera < 1 || choosenCamera > CamerasCount)
                    Console.Write("Неправильный ввод, попробуйте снова: ");

                Console.WriteLine($"Снято видео на камеру {choosenCamera}");
            }
        }
    }
}
