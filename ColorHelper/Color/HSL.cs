namespace ColorHelper
{
    public class HSL : IColor
    {
        public int H { get; set; }
        public byte S { get; set; }
        public byte L { get; set; }

        public HSL(int h, byte s, byte l)
        {
            this.H = h;
            this.S = s;
            this.L = l;
        }

        public override bool Equals(object obj)
        {
            var result = (HSL)obj;

            return (
                result != null &&
                this.H == result.H &&
                this.S == result.S &&
                this.L == result.L);
        }

        public override string ToString()
        {
            return $"{this.H}° {this.S}% {this.L}%";
        }
    }
}