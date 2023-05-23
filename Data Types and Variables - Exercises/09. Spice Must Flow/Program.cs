using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            uint yield = uint.Parse(Console.ReadLine());
            int daysCount = 0;
            uint spicesExtracted = 0;
            uint spicesExtractedTotal = 0;

            while (yield >= 100)
            {
                daysCount++;
                spicesExtracted = yield - 26;
                spicesExtractedTotal += spicesExtracted;
                yield -= 10;
            }

            if(spicesExtractedTotal >= 26)
            {
                spicesExtractedTotal -= 26;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(spicesExtractedTotal);
        }
    }
}
