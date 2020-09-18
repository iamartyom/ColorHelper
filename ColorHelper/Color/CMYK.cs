namespace ColorHelper.Color
{
    public class CMYK
    {
        private byte C { get; set; }
        private byte M { get; set; }
        private byte Y { get; set; }
        private byte K { get; set; }

        public CMYK(byte c, byte m, byte y, byte k)
        {
            this.C = c;
            this.M = m;
            this.Y = y;
            this.K = k;
        }
    }
}