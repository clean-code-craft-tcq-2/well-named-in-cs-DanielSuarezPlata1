using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public partial class Program
    {
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        private static int FetchPairNummber(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = FetchColorIndex(colorMapMajor,pair.majorColor);
            
            // Find the minor color in the array and get the index
            int minorIndex = FetchColorIndex(colorMapMinor,pair.minorColor);
            
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }

        private static int FetchColorIndex(Color[] colorMap, Color pairMajorColor)
        {
            // Find the color in the array and get the index
            int index = -1;
            for (int i = 0; i < colorMap.Length; i++)
            {
                if (colorMap[i] == pairMajorColor)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}