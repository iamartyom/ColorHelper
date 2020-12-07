# ColorHelper - Useful methods for work with colors

Supported color types:
- RGB
- HEX
- CMYK
- HSV
- HSL

This library provides several useful classes:

## ColorConverter

Convert RGB to HEX:
```
HEX hex = ColorConverter.RgbToHex(new RGB(10, 20, 30));
```

Convert Rgb to Cmyk:
```
CMYK cmyk = ColorConverter.RgbToCmyk(new RGB(10, 20, 30));
```

Convert Rgb to Hsv:
```
HSV hsv = ColorConverter.RgbToHsv(new RGB(10, 20, 30));
```

Convert Rgb to Hsl:
```
HSL hsl = ColorConverter.RgbToHsl(new RGB(10, 20, 30));
```

Convert Hex to Rgb:
```
RGB rgb = ColorConverter.HexToRgb(new HEX("#00FF00"));
```

Convert Hex to Cmyk:
```
CMYK cmyk = ColorConverter.HexToCmyk(new HEX("#00FF00"));
```

Convert Hex to Hsv:
```
HSV hsv = ColorConverter.HexToHsv(new HEX("#00FF00"));
```

Convert Hex to Hsl:
```
HSL hsl = ColorConverter.HexToHsl(new HEX("#00FF00"));
```

Convert Cmyk to Rgb:
```
RGB rgb = ColorConverter.CmykToRgb(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Hex:
```
HEX hex = ColorConverter.CmykToHex(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Hsv:
```
HSV hsv = ColorConverter.CmykToHsv(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Hsl:
```
HSL hsl = ColorConverter.CmykToHsl(new CMYK(0, 100, 0, 100));
```

Convert Hsv to Rgb:
```
RGB rgb = ColorConverter.HsvToRgb(new HSL(0, 0, 100));
```

Convert Hsv to Hex:
```
HEX hex = ColorConverter.HsvToHex(new HSL(0, 0, 100));
```

Convert Hsv to Cmyk:
```
CMYK cmyk = ColorConverter.HsvToCmyk(new HSL(0, 0, 100));
```

Convert Hsv to Hsl:
```
HSL hsl = ColorConverter.HsvToHsl(new HSL(0, 0, 100));
```

Convert Hsl to Rgb:
```
RGB rgb = ColorConverter.HslToRgb(new HSL(0, 0, 100));
```

Convert Hsl to Hex:
```
HEX hex = ColorConverter.HslToHex(new HSL(0, 0, 100));
```

Convert Hsl to Cmyk:
```
CMYK cmyk = ColorConverter.HslToCmyk(new HSL(0, 0, 100));
```

Convert Hsl to Hsv:
```
HSV hsv = ColorConverter.HslToHsv(new HSL(0, 0, 100));
```

## ColorComparer
```
bool result = ColorComparer.Equals(new RGB(100, 100, 100), new HEX("#FFFFFF"));
```

You can use **Equals** method with all pair color combinations.

## ColorGenerator

This class provides in this moment logic for get random colors.

Get random color:

```
RGB rgb = ColorGenerator.GetRandomColor<RGB>();
HEX hex = ColorGenerator.GetRandomColor<HEX>();
CMYK cmyk = ColorGenerator.GetRandomColor<CMYK>();
HSV hsv = ColorGenerator.GetRandomColor<HSV>();
HSL hsl = ColorGenerator.GetRandomColor<HSL>();
```

Get light random color:

```
RGB rgb = ColorGenerator.GetLightRandomColor<type>();
```

Get dark random color:

```
RGB rgb = ColorGenerator.GetDarkRandomColor<type>();
```
