using System;
using ColorHelper.Color;
using ColorHelper.Converter;

namespace ColorHelper.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RGB rgb;

            CMYK cmyk = ColorConverter.RgbToCmyk(new RGB(100, 200, 60));
            Console.WriteLine(cmyk);

            rgb = ColorConverter.CmykToRgb(new CMYK(88, 88, 0, 35));
            Console.WriteLine(rgb);

            HEX hex = ColorConverter.RgbToHex(new RGB(100, 100, 100));
            Console.WriteLine(hex);

            rgb = ColorConverter.HexToRgb(new HEX("FFFF90"));
            Console.WriteLine(rgb);
        }
    }
}
