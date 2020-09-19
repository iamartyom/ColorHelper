using System;
using ColorHelper.Color;

namespace ColorHelper.Converter
{
    public static class ColorConverter
    {
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