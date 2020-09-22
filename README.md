# ColorHelper - Useful methods for work with colors

Supported color types:
- RGB
- HEX
- CMYK

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

Convert Hex to Rgb:
```
RGB rgb = ColorConverter.HexToRgb(new HEX("#00FF00"));
```

Convert Hex to Cmyk:
```
CMYK cmyk = ColorConverter.HexToCmyk(new HEX("#00FF00"));
```

Convert Cmyk to Rgb:
```
RGB rgb = ColorConverter.CmykToRgb(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Hex:
```
HEX hex = ColorConverter.CmykToHex(new CMYK(0, 100, 0, 100));
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
```

Get light random color:

```
RGB rgb = ColorGenerator.GetLightRandomColor<RGB>();
HEX hex = ColorGenerator.GetLightRandomColor<HEX>();
CMYK cmyk = ColorGenerator.GetLightRandomColor<CMYK>();
```

Get dark random color:

```
RGB rgb = ColorGenerator.GetDarkRandomColor<RGB>();
HEX hex = ColorGenerator.GetDarkRandomColor<HEX>();
CMYK cmyk = ColorGenerator.GetDarkRandomColor<CMYK>();
```

Get red random color:

```
RGB rgb = ColorGenerator.GetRedRandomColor<RGB>();
HEX hex = ColorGenerator.GetRedRandomColor<HEX>();
CMYK cmyk = ColorGenerator.GetRedRandomColor<CMYK>();
```

Get green random color:

```
RGB rgb = ColorGenerator.GetGreenRandomColor<RGB>();
HEX hex = ColorGenerator.GetGreenRandomColor<HEX>();
CMYK cmyk = ColorGenerator.GetGreenRandomColor<CMYK>();
```

Get blue random color:

```
RGB rgb = ColorGenerator.GetBlueRandomColor<RGB>();
HEX hex = ColorGenerator.GetBlueRandomColor<HEX>();
CMYK cmyk = ColorGenerator.GetBlueRandomColor<CMYK>();
```
