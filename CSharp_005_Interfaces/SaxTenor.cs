using System;

namespace CSharp_005_Interfaces
{
    class SaxTenor : IInstrument
    {
        public void PlayFirstNote()
        {
            Console.WriteLine("First Note: SI BEMOL");
        }

        public void PlayFifthNote()
        {
            Console.WriteLine("First Note: FA");
        }
    }
}
