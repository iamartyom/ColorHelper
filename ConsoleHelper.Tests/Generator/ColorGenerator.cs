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

        [Test]
        [Repeat(10000)]
        public void GetRedRandomColor()
        {
            var result = ColorGenerator.GetRedRandomColor<RGB>();
            Assert.True(result.G == 0 && result.B == 0);
        }

        [Test]
        [Repeat(10000)]
        public void GetGreenRandomColor()
        {
            var result = ColorGenerator.GetGreenRandomColor<RGB>();
            Assert.True(result.R == 0 && result.B == 0);
        }

        [Test]
        [Repeat(10000)]
        public void GetBlueRandomColor()
        {
            var result = ColorGenerator.GetBlueRandomColor<RGB>();
            Assert.True(result.R == 0 && result.G == 0);
        }
    }
}