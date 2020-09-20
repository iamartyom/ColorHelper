using ColorHelper.Color;
using ColorHelper.Converter;
using NUnit.Framework;

namespace ConsoleHelper.Tests
{
    public class ColorConverter
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RgbToHex()
        {
            var result = ColorHelper.Converter.ColorConverter.RgbToHex(new RGB(1, 10, 30));
            Assert.AreEqual(new HEX("#010A1E"), result);
        }
    }
}