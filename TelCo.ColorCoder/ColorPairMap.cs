using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace TelCo.ColorCoder
{
   public  class ColorPairMap
    {
        public static Color[] CopyOfColorMapMajor = Program.ReturnColorMapMajor();
        public static Color[] CopyOfColorMapMinor = Program.ReturnColorMapMinor();
        public override string ToString()
        {
            int totalCombinations = CopyOfColorMapMajor.Length * CopyOfColorMapMinor.Length;
            String Result = null;
            for (int pairno = 1; pairno <= totalCombinations; pairno++)
            {
                ColorPairs pair = GetColorFromPairNumbers.GetColorFromPairNumber(pairno);
                Result += "Pair number: " + pairno.ToString() + " " + "Color Pair: " + pair.ToString() + '\n';
            }

            return Result;
        }

    }
}
