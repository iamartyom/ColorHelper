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

        public static bool Equals(RGB source, HSV target)
        {
            return source.Equals(ColorConverter.HsvToRgb(target));
        }

        public static bool Equals(RGB source, HSL target)
        {
            return source.Equals(ColorConverter.HslToRgb(target));
        }
        
        public static bool Equals(RGB source, XYZ target)
        {
            return source.Equals(ColorConverter.XyzToRgb(target));
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

        public static bool Equals(HEX source, HSV target)
        {
            return source.Equals(ColorConverter.HsvToHex(target));
        }

        public static bool Equals(HEX source, HSL target)
        {
            return source.Equals(ColorConverter.HslToHex(target));
        }
        
        public static bool Equals(HEX source, XYZ target)
        {
            return source.Equals(ColorConverter.XyzToHex(target));
        }

        public static bool Equals(CMYK source, RGB target)
        {
            return source.Equals(ColorConverter.RgbToCmyk(target));
        }

        public static bool Equals(CMYK source, HEX target)
        {
            return source.Equals(ColorConverter.HexToCmyk(target));
        }

        public static bool Equals(CMYK source, HSV target)
        {
            return source.Equals(ColorConverter.HsvToCmyk(target));
        }

        public static bool Equals(CMYK source, HSL target)
        {
            return source.Equals(ColorConverter.HslToCmyk(target));
        }

        public static bool Equals(CMYK source, CMYK target)
        {
            return source.Equals(target);
        }
        
        public static bool Equals(CMYK source, XYZ target)
        {
            return source.Equals(ColorConverter.XyzToCmyk(target));
        }

        public static bool Equals(HSV source, RGB target)
        {
            return source.Equals(ColorConverter.RgbToHsv(target));
        }

        public static bool Equals(HSV source, HEX target)
        {
            return source.Equals(ColorConverter.HexToHsv(target));
        }

        public static bool Equals(HSV source, CMYK target)
        {
            return source.Equals(ColorConverter.CmykToHsv(target));
        }

        public static bool Equals(HSV source, HSV target)
        {
            return source.Equals(target);
        }

        public static bool Equals(HSV source, HSL target)
        {
            return source.Equals(ColorConverter.HslToHsv(target));
        }
        
        public static bool Equals(HSV source, XYZ target)
        {
            return source.Equals(ColorConverter.XyzToHsv(target));
        }

        public static bool Equals(HSL source, RGB target)
        {
            return source.Equals(ColorConverter.RgbToHsl(target));
        }

        public static bool Equals(HSL source, HEX target)
        {
            return source.Equals(ColorConverter.HexToHsl(target));
        }

        public static bool Equals(HSL source, CMYK target)
        {
            return source.Equals(ColorConverter.CmykToHsl(target));
        }

        public static bool Equals(HSL source, HSV target)
        {
            return source.Equals(ColorConverter.HsvToHsl(target));
        }
        
        public static bool Equals(HSL source, XYZ target)
        {
            return source.Equals(ColorConverter.XyzToHsl(target));
        }
        
        public static bool Equals(XYZ source, RGB target)
        {
            return source.Equals(ColorConverter.RgbToXyz(target));
        }
        
        public static bool Equals(XYZ source, HEX target)
        {
            return source.Equals(ColorConverter.HexToXyz(target));
        }
        
        public static bool Equals(XYZ source, CMYK target)
        {
            return source.Equals(ColorConverter.CmykToXyz(target));
        }
        
        public static bool Equals(XYZ source, HSV target)
        {
            return source.Equals(ColorConverter.HsvToXyz(target));
        }
        
        public static bool Equals(XYZ source, HSL target)
        {
            return source.Equals(ColorConverter.HslToXyz(target));
        }
    }
}
