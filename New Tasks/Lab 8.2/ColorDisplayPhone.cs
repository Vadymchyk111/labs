using System;
using System.Linq;

namespace Lab_8._2
{
    class ColorDisplayPhone : BlackAndWhitePhone
    {
        public int ScreenColorsQuantity { get; set; }
        public bool TwoSim { get; set; }
        public string SecondaryPhoneNumber { get; set; }

        public ColorDisplayPhone(string phoneNumber, int screenWidth, int screenHeight,
            float screenSize, string phoneColor, int screenColorsQuantity, string secondaryPhoneNumber = null)
            : base(phoneNumber, screenWidth, screenHeight, screenSize, phoneColor)
        {
            ScreenColorsQuantity = screenColorsQuantity;
            SecondaryPhoneNumber = secondaryPhoneNumber;
            TwoSim = SecondaryPhoneNumber != null;
        }
        public override void CallToNumber()
        {
            if (!TwoSim)
                base.CallToNumber();
            else
            {
                Console.Write("Выберите с какой сим-карты позвонить: ");
                int choosenSim;
                while (!int.TryParse(Console.ReadLine(), out choosenSim) || choosenSim < 1 || choosenSim > 2)
                    Console.WriteLine("Ввод неправильный, повторите попытку: ");

                string number;
                while (true)
                {
                    number = null;

                    Console.Write("Введите номер абонента: ");
                    while (string.IsNullOrEmpty(number))
                    {
                        number = Console.ReadLine();
                        if (string.IsNullOrEmpty(number))
                            Console.WriteLine("Ввод неправильный, повторите попытку: ");
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

                Console.WriteLine($"Вы позвонили с сим-карты с номером: {(choosenSim == 1 ? PhoneNumber : SecondaryPhoneNumber)} на номер: {number}");
            }
        }
        public override void SendSmsToNumber()
        {
            if (!TwoSim)
                base.SendSmsToNumber();
            else
            {
                Console.Write("Выберите с какой сим-карты отправить СМС сообщение: ");
                int choosenSim;
                while (!int.TryParse(Console.ReadLine(), out choosenSim) || choosenSim < 1 || choosenSim > 2)
                    Console.WriteLine("Ввод неправильный, повторите попытку: ");

                string number;
                while (true)
                {
                    number = null;

                    Console.Write("Введите номер абонента: ");
                    while (string.IsNullOrEmpty(number))
                    {
                        number = Console.ReadLine();
                        if (string.IsNullOrEmpty(number))
                            Console.WriteLine("Ввод неправильный, повторите попытку: ");
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

                Console.WriteLine($"SMS сообщение отправлено с сим-карты с номером: {(choosenSim == 1 ? PhoneNumber : SecondaryPhoneNumber)} на номер: {number}");
            }
        }
        public virtual void SendMmsToNumber()
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
                        Console.WriteLine("Ввод неправильный, повторите попытку: ");
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

            if (!TwoSim)
                Console.WriteLine($"Исходящее ММС сообщение отправлено на номер: {number}");
            else
            {
                Console.Write("Выберите с какой сим-карты отправить ММС сообщение: ");
                int choosenSim;
                while (!int.TryParse(Console.ReadLine(), out choosenSim) || choosenSim < 1 || choosenSim > 2)
                    Console.WriteLine("Ввод неправильный, повторите попытку: ");

                Console.WriteLine($"MMS сообщение отправлено с сим-карты с номером: {(choosenSim == 1 ? PhoneNumber : SecondaryPhoneNumber)} на номер: {number}");
            }
        }
        public virtual void TakeMmsFromNumber(string senderPhoneNumber)
        {
            Console.WriteLine($"Входящее MMS сообщение. Номер: {senderPhoneNumber}");
        }
    }
}
