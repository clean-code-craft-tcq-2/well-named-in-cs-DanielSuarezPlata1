using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Data type defined to hold the two colors of color pair
    /// </summary>
    public class ColorPair
    {
        public Color majorColor { get; set; }
        public Color minorColor { get; set; }

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
