using System;

namespace ColorHelper
{
    public static class ColorGenerator
    {
        public static T GetRandomColor<T>() where T: IColor
        {
            return GetRandomColor<T>(new RgbRandomColorFilter());
        }

        public static T GetLightRandomColor<T>() where T : IColor
        {
            const byte minRangeValue = 170;

            RgbRandomColorFilter filter = new RgbRandomColorFilter();
            filter.minR = minRangeValue;
            filter.minG = minRangeValue;
            filter.minB = minRangeValue;

            return GetRandomColor<T>(filter);
        }

        public static T GetDarkRandomColor<T>() where T : IColor
        {
            const byte maxRangeValue = 80;

            RgbRandomColorFilter filter = new RgbRandomColorFilter();
            filter.maxR = maxRangeValue;
            filter.maxG = maxRangeValue;
            filter.maxB = maxRangeValue;

            return GetRandomColor<T>(filter);
        }

        public static T GetRedRandomColor<T>() where T : IColor
        {
            RgbRandomColorFilter filter = new RgbRandomColorFilter();
            filter.maxG = 0;
            filter.maxB = 0;

            return GetRandomColor<T>(filter);
        }

        public static T GetGreenRandomColor<T>() where T : IColor
        {
            RgbRandomColorFilter filter = new RgbRandomColorFilter();
            filter.maxR = 0;
            filter.maxB = 0;

            return GetRandomColor<T>(filter);
        }

        public static T GetBlueRandomColor<T>() where T : IColor
        {
            RgbRandomColorFilter filter = new RgbRandomColorFilter();
            filter.maxR = 0;
            filter.maxG = 0;

            return GetRandomColor<T>(filter);
        }

        private static T GetRandomColor<T>(RgbRandomColorFilter filter) where T : IColor
        {
            Random random = new Random(DateTime.Now.Millisecond);

            RGB rgb = new RGB(
                (byte)random.Next(filter.minR, filter.maxR),
                (byte)random.Next(filter.minG, filter.maxG),
                (byte)random.Next(filter.minB, filter.maxB));
            
            return ConvertRgbToNecessaryColorType<T>(rgb);
        }

        private static T ConvertRgbToNecessaryColorType<T>(RGB rgb) where T: IColor
        {
            if (typeof(T) == typeof(RGB))
            {
                return (T)(object)rgb;
            }
            else if (typeof(T) == typeof(HEX))
            {
                return (T)(object)ColorConverter.RgbToHex(rgb);
            }
            else if (typeof(T) == typeof(CMYK))
            {
                return (T)(object)ColorConverter.RgbToCmyk(rgb);
            }
            else
            {
                throw new ArgumentException("Incorrect class type");
            }
        }
    }
}
