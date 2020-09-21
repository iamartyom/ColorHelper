namespace ColorHelper
{
    public class CMYK : IColor
    {
        public byte C { get; set; }
        public byte M { get; set; }
        public byte Y { get; set; }
        public byte K { get; set; }

        public CMYK(byte c, byte m, byte y, byte k)
        {
            this.C = c;
            this.M = m;
            this.Y = y;
            this.K = k;
        }

        public override bool Equals(object obj)
        {
            var result = (CMYK)obj;

            return (
                result != null &&
                this.C == result.C &&
                this.M == result.M &&
                this.Y == result.Y &&
                this.K == result.K);
        }

        public override string ToString()
        {
            return $"{this.C}% {this.M}% {this.Y}% {this.K}%";
        }
    }
}