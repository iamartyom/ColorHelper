using System;
using System.Collections.Generic;
using System.Linq;
using ColorHelper.Color;

namespace ColorHelper.Converter
{
    public static class ColorConverter
    {
        public static CMYK RgbToCmyk(RGB rgb)
        {
            double r, g, b, c, m, y, k;

            r = rgb.R;
            g = rgb.G;
            b = rgb.B;

            k = 1 - new List<double>() { (r / 255), (g / 255), (b / 255) }.Max();
            c = (1 - (r / 255) - k) / (1 - k);
            m = (1 - (g / 255) - k) / (1 - k);
            y = (1 - (b / 255) - k) / (1 - k);

            return new CMYK((byte)Math.Round(c * 100),
                (byte)Math.Round(m * 100),
                (byte)Math.Round(y * 100),
                (byte)Math.Round(k * 100));
        }

        public static RGB CmykToRgb(CMYK cmyk)
        {
            return new RGB(
                (byte)Math.Round(255 * (1 - cmyk.C * 0.01) * (1 - cmyk.K * 0.01)),
                (byte)Math.Round(255 * (1 - cmyk.M * 0.01) * (1 - cmyk.K * 0.01)),
                (byte)Math.Round(255 * (1 - cmyk.Y * 0.01) * (1 - cmyk.K * 0.01)));
        }

        public static HEX RgbToHex(RGB rgb)
        {
            return new HEX($"{rgb.R:X2}{rgb.G:X2}{rgb.B:X2}");
        }

        public static RGB HexToRgb(HEX hex)
        {
            int value = Convert.ToInt32(hex.Value, 16);
            return new RGB(
                (byte)((value >> 16) & 255),
                (byte)((value >> 8) & 255),
                (byte)(value & 255));
        }
    }
}