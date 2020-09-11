﻿using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor;
        public static Color[] ReturnColorMapMajor()
        {
            return colorMapMajor;
        }
        public static Color[] ReturnColorMapMinor()
        {
            return colorMapMinor;
        }
        public static void SetColorMapMajor(Color[] colorMap)
        {
            Program.colorMapMinor = colorMap;
        }
        public static void SetColorMapMinor(Color[] colorMap)
        {
            Program.colorMapMinor = colorMap;
        }
        /// <summary>
        /// data type defined to hold the two colors of clor pair
        /// </summary>

        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static Program()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>

        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>

        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>

    }
}
