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
        public void CmykToHsl()
        {
            var result = ColorConverter.CmykToHsl(new CMYK(10, 10, 10, 10));
            Assert.AreEqual(new HSL(0, 0, 81), result);
        }

        [Test]
        public void HslToRgb()
        {
            var result = ColorConverter.HslToRgb(new HSL(201, 78, 20));
            Assert.AreEqual(new RGB(11, 63, 91), result);
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
    }
}