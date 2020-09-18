using ColorHelper.Color;

namespace ColorHelper.Converter
{
    public static class ColorConverter
    {
        public static HEX RgbToHex(RGB rgb)
        {
            return new HEX($"{rgb.R:X2}{rgb.G:X2}{rgb.B:X2}");
        }
    }
}