using System;

namespace Lab_8._2
{
    class Program
    {
        static void Main()
        {
            RotaryPhone rotaryPhone = new RotaryPhone("098523");
            rotaryPhone.CallToNumber();
            rotaryPhone.TakeIncomingCall("123");

            KeyboardPhone keyboardPhone = new KeyboardPhone("09123");
            keyboardPhone.CallToNumber();
            keyboardPhone.TakeIncomingCall("123");

            Console.ReadLine();
        }
    }
}
