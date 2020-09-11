using System;
using System.Collections.Generic;
using System.Text;
using static TelCo.ColorCoder.ColorPairs;

namespace TelCo.ColorCoder
{
    class GetColorFromPairNumbers
    {
        public static ColorPairs GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = Program.colorMapMinor.Length;
            int majorSize = Program.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {

                string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber);
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            ColorPairs pair = new ColorPairs()
            {
                majorColor = Program.colorMapMajor[majorIndex],
                minorColor = Program.colorMapMinor[minorIndex]
            };

            // return the value
            return pair;
        }
    }
}
