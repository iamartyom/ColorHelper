using ColorHelper;
using NUnit.Framework;

namespace ConsoleHelper.Tests
{
    public class ColorGeneratorTests
    {
        [Test]
        public void GetRandomColorRgb()
        {
            var result = ColorGenerator.GetRandomColor<RGB>();
            Assert.NotNull((RGB)result);
        }

        [Test]
        public void GetRandomColorHex()
        {
            var result = ColorGenerator.GetRandomColor<HEX>();
            Assert.NotNull((HEX)result);
        }

        [Test]
        public void GetRandomColorCmyk()
        {
            var result = ColorGenerator.GetRandomColor<CMYK>();
            Assert.NotNull((CMYK)result);
        }

        [Test]
        public void GetRandomColorHsv()
        {
            var result = ColorGenerator.GetRandomColor<HSV>();
            Assert.NotNull((HSV)result);
        }

        [Test]
        public void GetRandomColorHsl()
        {
            var result = ColorGenerator.GetRandomColor<HSL>();
            Assert.NotNull((HSL)result);
        }

        [Test]
        [Repeat(10000)]
        public void GetLightRandomColor()
        {
            var result = ColorGenerator.GetLightRandomColor<RGB>();
            Assert.That(result.R, Is.GreaterThanOrEqualTo(170));
            Assert.That(result.G, Is.GreaterThanOrEqualTo(170));
            Assert.That(result.B, Is.GreaterThanOrEqualTo(170));
        }

        [Test]
        [Repeat(10000)]
        public void GetDarkRandomColor()
        {
            var result = ColorGenerator.GetDarkRandomColor<RGB>();
            Assert.That(result.R, Is.LessThanOrEqualTo(80));
            Assert.That(result.G, Is.LessThanOrEqualTo(80));
            Assert.That(result.B, Is.LessThanOrEqualTo(80));
        }
    }
}