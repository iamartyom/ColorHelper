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
