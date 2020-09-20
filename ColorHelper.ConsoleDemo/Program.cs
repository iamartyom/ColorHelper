using System;

namespace ColorHelper.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RGB rgb;
            HEX hex;
            CMYK cmyk;

            rgb = ColorConverter.HexToRgb(new HEX("FFFF90"));
            Console.WriteLine(rgb);

            rgb = ColorConverter.CmykToRgb(new CMYK(88, 88, 0, 35));
            Console.WriteLine(rgb);

            hex = ColorConverter.RgbToHex(new RGB(100, 100, 100));
            Console.WriteLine(hex);

            hex = ColorConverter.CmykToHex(new CMYK(100, 50, 0, 38));
            Console.WriteLine(hex);

            cmyk = ColorConverter.RgbToCmyk(new RGB(100, 200, 60));
            Console.WriteLine(cmyk);

            cmyk = ColorConverter.HexToCmyk(new HEX("00FF00"));
            Console.WriteLine(cmyk);
        }
    }
}
