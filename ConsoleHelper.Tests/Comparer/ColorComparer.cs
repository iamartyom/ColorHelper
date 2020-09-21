using ColorHelper;
using NUnit.Framework;

namespace ConsoleHelper.Tests
{
    public class ColorComparerTests
    {
        [Test]
        public void Equals_RgbRgb_Correct()
        {
            var source = new RGB(30, 20, 50);
            var target = new RGB(30, 20, 50);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbRgb_Incorrect()
        {
            var source = new RGB(30, 20, 50);
            var target = new RGB(100, 150, 200);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHex_Correct()
        {
            var source = new RGB(10, 20, 25);
            var target = new HEX("#0A1419");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHex_Incorrect()
        {
            var source = new RGB(100, 101, 102);
            var target = new HEX("#FFFFFF");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbCmyk_Correct()
        {
            var source = new RGB(53, 53, 59);
            var target = new CMYK(9, 9, 0, 77);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbCmyk_Incorrect()
        {
            var source = new RGB(0, 255, 0);
            var target = new CMYK(50, 50, 50, 50);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexRgb_Correct()
        {
            var source = new HEX("#1C1CD9");
            var target = new RGB(28, 28, 217);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexRgb_Incorrect()
        {
            var source = new HEX("#000028");
            var target = new RGB(100, 100, 100);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHex_Correct()
        {
            var source = new HEX("#00FFFF");
            var target = new HEX("00FFFF");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHex_Incorrect()
        {
            var source = new HEX("#000000");
            var target = new HEX("#FFFFFF");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexCmyk_Correct()
        {
            var source = new CMYK(75, 0, 19, 9);
            var target = new HEX("#3AE8BD");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexCmyk_Incorrect()
        {
            var source = new CMYK(100, 0, 100, 0);
            var target = new HEX("#121212");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykRgb_Correct()
        {
            var source = new CMYK(60, 0, 60, 18);
            var target = new RGB(84, 209, 84);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykRgb_Incorrect()
        {
            var source = new CMYK(0, 5, 0, 10);
            var target = new RGB(2, 10, 30);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHex_Correct()
        {
            var source = new CMYK(0, 82, 4, 30);
            var target = new HEX("#B320AB");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHex_Incorrect()
        {
            var source = new CMYK(0, 100, 0, 20);
            var target = new HEX("#BABABA");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykCmyk_Correct()
        {
            var source = new CMYK(10, 50, 90, 100);
            var target = new CMYK(10, 50, 90, 100);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykCmyk_Incorrect()
        {
            var source = new CMYK(10, 10, 10, 100);
            var target = new CMYK(0, 0, 0, 0);

            Assert.False(ColorComparer.Equals(source, target));
        }
    }
}