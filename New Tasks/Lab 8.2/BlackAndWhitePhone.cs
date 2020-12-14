using System;
using System.Linq;

namespace Lab_8._2
{
    class BlackAndWhitePhone : KeyboardPhone
    {
        public override char[] AvailableSymbols => new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '+'};
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public float ScreenSize { get; set; }
        public string PhoneColor { get; set; }

        public BlackAndWhitePhone(string phoneNumber, int screenWidth, int screenHeight, float screenSize, string phoneColor) : base(phoneNumber)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            ScreenSize = screenSize;
            PhoneColor = phoneColor;
        }
        public virtual void SendSmsToNumber()
        {
            string number;

            while (true)
            {
                number = null;

                Console.Write("Введите номер абонента: ");
                while (string.IsNullOrEmpty(number))
                {
                    number = Console.ReadLine();
                    if (string.IsNullOrEmpty(number))
                        Console.WriteLine("Неправильный ввод, повторите попытку: ");
                }

                bool invalidNumber = false;
                foreach (char symbol in number)
                    if (!AvailableSymbols.Contains(symbol))
                    {
                        invalidNumber = true;
                        break;
                    }

                if (invalidNumber)
                    Console.Write("На клавиатуре нет используемых символов, введите номер еще раз: ");
                else break;
            }

            Console.WriteLine($"СМС сообщение отправлено на номер {number}");
        }

        public virtual void TakeSmsFromNumber(string senderPhoneNumber)
        {
            Console.WriteLine($"Входящее СМС сообщение от {senderPhoneNumber}");
        }
    }
}
