using System;

namespace CSharp_005_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IInstrument instrument1 = new Piano();
            instrument1.PlayFirstNote();
            instrument1.PlayFifthNote();

            IInstrument instrument2 = new SaxTenor();
            instrument2.PlayFirstNote();
            instrument2.PlayFifthNote();
        }
    }
}
