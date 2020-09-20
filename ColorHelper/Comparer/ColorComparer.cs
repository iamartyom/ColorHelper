namespace ColorHelper
{
    public static class ColorComparer
    {
        public static bool Equals(RGB source, RGB target)
        {
            return source.Equals(target);
        }

        public static bool Equals(RGB source, HEX target)
        {
            return source.Equals(ColorConverter.HexToRgb(target));
        }

        public static bool Equals(RGB source, CMYK target)
        {
            return source.Equals(ColorConverter.CmykToRgb(target));
        }

        public static bool Equals(HEX source, RGB target)
        {
            return source.Equals(ColorConverter.RgbToHex(target));
        }

        public static bool Equals(HEX source, HEX target)
        {
            return source.Equals(target);
        }

        public static bool Equals(HEX source, CMYK target)
        {
            return source.Equals(ColorConverter.CmykToHex(target));
        }

        public static bool Equals(CMYK source, RGB target)
        {
            return source.Equals(ColorConverter.RgbToCmyk(target));
        }

        public static bool Equals(CMYK source, HEX target)
        {
            return source.Equals(ColorConverter.HexToCmyk(target));
        }

        public static bool Equals(CMYK source, CMYK target)
        {
            return source.Equals(target);
        }
    }
}
