using System;
using ZUtilities.DataConverters.B;

namespace ZUtilities.DataConvertes.B.CUI
{
    class Program
    {


        static void Main(string[] args)
        {
            InputData input = new InputData();

            Boolean parsingIsSuccess = InputData.TryParse("Вынос_Snap_60,2020-02-10 17:11:20,5515579.651,3211206.430", out input);
            Console.WriteLine($"Parsing is success: {parsingIsSuccess}");
            if(parsingIsSuccess) Console.WriteLine(input.AsOutputString());
        }
    }
}
