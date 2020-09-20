using System;
using ColorHelper.Color;
using ColorHelper.Converter;

namespace ColorHelper.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CMYK cmyk = ColorConverter.RgbToCmyk(new RGB(100, 200, 60));
            Console.WriteLine(cmyk);

            HEX hex = ColorConverter.RgbToHex(new RGB(100, 100, 100));
            Console.WriteLine(hex);

            RGB rgb = ColorConverter.HexToRgb(new HEX("FFFF90"));
            Console.WriteLine(rgb);
        }
    }
}
