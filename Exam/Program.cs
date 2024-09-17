using System;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MobilePad.OldPhonePad("222 2 22"));
            Console.WriteLine(MobilePad.OldPhonePad("33#"));
            Console.WriteLine(MobilePad.OldPhonePad("227*#"));
            Console.WriteLine(MobilePad.OldPhonePad("4433555 555666#"));
            Console.WriteLine(MobilePad.OldPhonePad("8 88777444666*664#"));
            Console.ReadLine();
        }
    }
}
