namespace ColorHelper.Color
{
    public class RGB
    {
        private byte R { get; set; }
        private byte G { get; set; }
        private byte B { get; set; }

        public RGB(byte r, byte g, byte b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }
    }
}