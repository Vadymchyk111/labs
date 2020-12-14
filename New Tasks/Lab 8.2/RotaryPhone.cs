using System;
using System.Linq;

namespace Lab_8._2
{
    class RotaryPhone
    {
        public string PhoneNumber { get; set; }
        public virtual char[] AvailableSymbols => new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public RotaryPhone(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public virtual void CallToNumber()
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
            
            Console.WriteLine($"Выполняется звонок на номер: {number}");
        }
        public virtual void TakeIncomingCall(string callingPhoneNumber)
        {
            Console.WriteLine("Входящий вызов");
        }
    }
}
