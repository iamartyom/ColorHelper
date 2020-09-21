namespace ColorHelper
{
    public class RGB : IColor
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public RGB(byte r, byte g, byte b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public override bool Equals(object obj)
        {
            var result = (RGB) obj;

            return (
                    result != null &&
                    this.R == result.R &&
                    this.G == result.G &&
                    this.B == result.B);
        }

        public override string ToString()
        {
            return $"rgb({this.R}, {this.G}, {this.B})";
        }
    }
}