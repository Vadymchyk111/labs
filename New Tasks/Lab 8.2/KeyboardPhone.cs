using System;

namespace Lab_8._2
{
    class KeyboardPhone : RotaryPhone
    {
        public override char[] AvailableSymbols => new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#' };

        public KeyboardPhone(string phoneNumber) : base(phoneNumber)
        { }
        public override void TakeIncomingCall(string callingPhoneNumber)
        {
            Console.WriteLine($"Звонят с номера: {callingPhoneNumber}");
        }
    }
}
