using System;

namespace CSharp_005_Interfaces
{
    class Piano : IInstrument
    {
        public void PlayFirstNote()
        {
            Console.WriteLine("First Note: DO");
        }

        public void PlayFifthNote()
        {
            Console.WriteLine("Fifth Note: SOL");
        }
    }
}
