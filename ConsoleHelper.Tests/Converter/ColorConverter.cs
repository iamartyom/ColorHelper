using ColorHelper;
using NUnit.Framework;

namespace ConsoleHelper.Tests
{
    public class ColorConverterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RgbToHex()
        {
            var result = ColorConverter.RgbToHex(new RGB(1, 10, 30));
            Assert.AreEqual(new HEX("#010A1E"), result);
        }

        [Test]
        public void RgbToCmyk()
        {
            var result = ColorConverter.RgbToCmyk(new RGB(38,150,38));
            Assert.AreEqual(new CMYK(75, 0, 75, 41), result);
        }

        [Test]
        public void RgbToHsv()
        {
            var result = ColorConverter.RgbToHsv(new RGB(137, 32, 179));
            Assert.AreEqual(new HSV(283, 82, 70), result);
        }

        [Test]
        public void RgbToHsl()
        {
            var result = ColorConverter.RgbToHsl(new RGB(20, 20, 80));
            Assert.AreEqual(new HSL(240, 60, 20), result);
        }

        [Test]
        public void HexToRgb()
        {
            var result = ColorConverter.HexToRgb(new HEX("#6E34BF"));
            Assert.AreEqual(new RGB(110, 52, 191), result);
        }

        [Test]
        public void HexToCmyk()
        {
            var result = ColorConverter.HexToCmyk(new HEX("#6984CF"));
            Assert.AreEqual(new CMYK(49, 36, 0, 19), result);
        }

        [Test]
        public void HexToHsv()
        {
            var result = ColorConverter.HexToHsv(new HEX("#3278C2"));
            Assert.AreEqual(new HSV(211, 74, 76), result);
        }

        [Test]
        public void HexToHsl()
        {
            var result = ColorConverter.HexToHsl(new HEX("#323264"));
            Assert.AreEqual(new HSL(240, 33, 29), result);
        }

        [Test]
        public void CmykToRgb()
        {
            var result = ColorConverter.CmykToRgb(new CMYK(65, 0, 40, 30));
            Assert.AreEqual(new RGB(62, 178, 107), result);
        }

        [Test]
        public void CmykToHex()
        {
            var result = ColorConverter.CmykToHex(new CMYK(2, 0, 31, 9));
            Assert.AreEqual(new HEX("#E3E8A0"), result);
        }

        [Test]
        public void CmykToHsv()
        {
            var result = ColorConverter.CmykToHsv(new CMYK(56, 0, 34, 32));
            Assert.AreEqual(new HSV(144, 56, 68), result);
        }

        [Test]
        public void CmykToHsl()
        {
            var result = ColorConverter.CmykToHsl(new CMYK(10, 10, 10, 10));
            Assert.AreEqual(new HSL(0, 0, 81), result);
        }

        [Test]
        public void HsvToRgb()
        {
            var result = ColorConverter.HsvToRgb(new HSV(240, 80, 64));
            Assert.AreEqual(new RGB(32, 32, 162), result);
        }

        [Test]
        public void HsvToRgbBlack()
        {
            var result = ColorConverter.HsvToRgb(new HSV(0, 0, 0));
            Assert.AreEqual(new RGB(0, 0, 0), result);
        }

        [Test]
        public void HsvToRgbWhite()
        {
            var result = ColorConverter.HsvToRgb(new HSV(0, 0, 100));
            Assert.AreEqual(new RGB(255, 255, 255), result);
        }


        [Test]
        public void HsvToHex()
        {
            var result = ColorConverter.HsvToHex(new HSV(240, 80, 64));
            Assert.AreEqual(new HEX("2020A2"), result);
        }

        [Test]
        public void HsvToCmyk()
        {
            var result = ColorConverter.HsvToCmyk(new HSV(240, 80, 64));
            Assert.AreEqual(new CMYK(80, 80, 0, 36), result);
        }

        [Test]
        public void HsvToHsl()
        {
            var result = ColorConverter.HsvToHsl(new HSV(240, 80, 64));
            Assert.AreEqual(new HSL(240, 67, 38), result);
        }

        [Test]
        public void HslToRgb()
        {
            var result = ColorConverter.HslToRgb(new HSL(201, 78, 20));
            Assert.AreEqual(new RGB(11, 63, 91), result);
        }

        [Test]
        public void HslToRgbBlack()
        {
            var result = ColorConverter.HslToRgb(new HSL(0, 0, 0));
            Assert.AreEqual(new RGB(0, 0, 0), result);
        }

        [Test]
        public void HslToRgbWhite()
        {
            var result = ColorConverter.HslToRgb(new HSL(0, 0, 100));
            Assert.AreEqual(new RGB(255, 255, 255), result);
        }


        [Test]
        public void HslToHex()
        {
            var result = ColorConverter.HslToHex(new HSL(260, 77, 31));
            Assert.AreEqual(new HEX("#3B128C"), result);
        }

        [Test]
        public void HslToCmyk()
        {
            var result = ColorConverter.HslToCmyk(new HSL(336, 70, 30));
            Assert.AreEqual(new CMYK(0, 82, 49, 49), result);
        }

        [Test]
        public void HslToHsv()
        {
            var result = ColorConverter.HslToHsv(new HSL(338, 56, 18));
            Assert.AreEqual(new HSV(338, 72, 28), result);
        }


      
 

    }
}