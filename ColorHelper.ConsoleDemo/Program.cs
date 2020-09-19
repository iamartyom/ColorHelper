using System;
using ColorHelper.Color;
using ColorHelper.Converter;

namespace ColorHelper.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HEX hex = ColorConverter.RgbToHex(new RGB(100, 100, 100));
            Console.WriteLine(hex);

            RGB rgb = ColorConverter.HexToRgb(new HEX("FFFF90"));
            Console.WriteLine(rgb);
        }
    }
}
