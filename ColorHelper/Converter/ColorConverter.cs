using System;
using System.Collections.Generic;
using System.Linq;

namespace ColorHelper
{
    public static class ColorConverter
    {
        public static HEX RgbToHex(RGB rgb)
        {
            return new HEX($"{rgb.R:X2}{rgb.G:X2}{rgb.B:X2}");
        }

        public static CMYK RgbToCmyk(RGB rgb)
        {
            double modifiedR, modifiedG, modifiedB, c, m, y, k;

            modifiedR = rgb.R / 255.0;
            modifiedG = rgb.G / 255.0;
            modifiedB = rgb.B / 255.0;

            k = 1 - new List<double>() { modifiedR, modifiedG, modifiedB }.Max();
            c = (1 - modifiedR - k) / (1 - k);
            m = (1 - modifiedG - k) / (1 - k);
            y = (1 - modifiedB - k) / (1 - k);

            return new CMYK((byte)Math.Round(c * 100),
                (byte)Math.Round(m * 100),
                (byte)Math.Round(y * 100),
                (byte)Math.Round(k * 100));
        }

        public static HSL RgbToHsl(RGB rgb)
        {
            double modifiedR, modifiedG, modifiedB, min, max, delta, h, s, l;

            modifiedR = rgb.R / 255.0;
            modifiedG = rgb.G / 255.0;
            modifiedB = rgb.B / 255.0;

            min = new List<double>() { modifiedR, modifiedG, modifiedB }.Min();
            max = new List<double>() { modifiedR, modifiedG, modifiedB }.Max();
            delta = max - min;
            l = (min + max) / 2;

            if (delta == 0)
            {
                h = 0;
                s = 0;
            }
            else
            {
                s = (l <= 0.5) ? (delta / (min + max)) : (delta / (2 - max - min));

                if (modifiedR == max)
                {
                    h = (modifiedG - modifiedB) / 6 / delta;
                }
                else if (modifiedG == max)
                {
                    h = (1.0 / 3) + ((modifiedB - modifiedR) / 6 / delta);
                }
                else
                {
                    h = (2.0 / 3) + ((modifiedR - modifiedG) / 6 / delta);
                }

                h = (h < 0) ? ++h : h;
                h = (h > 1) ? --h : h;
            }

            return new HSL(
                (int)Math.Round(h * 360),
                (byte)Math.Round(s * 100),
                (byte)Math.Round(l * 100));
        }

        public static RGB HexToRgb(HEX hex)
        {
            int value = Convert.ToInt32(hex.Value, 16);
            return new RGB(
                (byte)((value >> 16) & 255),
                (byte)((value >> 8) & 255),
                (byte)(value & 255));
        }

        public static CMYK HexToCmyk(HEX hex)
        {
            return RgbToCmyk(HexToRgb(hex));
        }

        public static HSL HexToHsl(HEX hex)
        {
            return RgbToHsl(HexToRgb(hex));
        }

        public static RGB CmykToRgb(CMYK cmyk)
        {
            return new RGB(
                (byte)Math.Round(255 * (1 - cmyk.C * 0.01) * (1 - cmyk.K * 0.01)),
                (byte)Math.Round(255 * (1 - cmyk.M * 0.01) * (1 - cmyk.K * 0.01)),
                (byte)Math.Round(255 * (1 - cmyk.Y * 0.01) * (1 - cmyk.K * 0.01)));
        }

        public static HEX CmykToHex(CMYK cmyk)
        {
            return RgbToHex(CmykToRgb(cmyk));
        }

        public static HSL CmykToHsl(CMYK cmyk)
        {
            return RgbToHsl(CmykToRgb(cmyk));
        }

        public static RGB HslToRgb(HSL hsl)
        {
            double modifiedH, modifiedS, modifiedL, r = 1, g = 1, b = 1, q, p;

            modifiedH = hsl.H / 360.0;
            modifiedS = hsl.S / 100.0;
            modifiedL = hsl.L / 100.0;

            q = (modifiedL < 0.5) ? modifiedL * (1 + modifiedS) : modifiedL + modifiedS - modifiedL * modifiedS;
            p = 2 * modifiedL - q;

            if (modifiedS != 0)
            {
                r = GetHue(p, q, modifiedH + 1.0 / 3);
                g = GetHue(p, q, modifiedH);
                b = GetHue(p, q, modifiedH - 1.0 / 3);
            }

            return new RGB((byte)Math.Round(r * 255), (byte)Math.Round(g * 255), (byte)Math.Round(b * 255));
        }

        private static double GetHue(double p, double q, double t)
        {
            double value = p;

            if (t < 0) t++;
            if (t > 1) t--;

            if (t < 1.0 / 6)
            {
                value = p + (q - p) * 6 * t;
            }
            else if (t < 1.0 / 2)
            {
                value = q;
            }
            else if (t < 2.0 / 3)
            {
                value = p + (q - p) * (2.0 / 3 - t) * 6;
            }

            return value;
        }

        public static HEX HslToHex(HSL hsl)
        {
            return RgbToHex(HslToRgb(hsl));
        }

        public static CMYK HslToCmyk(HSL hsl)
        {
            return RgbToCmyk(HslToRgb(hsl));
        }

        public static HSV HslToHsv(HSL hsl)
        {
            double modifiedS, modifiedL, hsvS, hsvV;

            modifiedS = hsl.S / 100.0;
            modifiedL = hsl.L / 100.0;

            hsvV = modifiedL + modifiedS * Math.Min(modifiedL, 1 - modifiedL);

            hsvS = (hsvV == 0) ? 0 : 2 * (1 - modifiedL / hsvV);

            return new HSV(hsl.H, (byte)Math.Round(hsvS * 100), (byte)Math.Round(hsvV * 100));
        }
    }
}