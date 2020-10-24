namespace ColorHelper
{
    public class HSV : IColor
    {
        public int H { get; set; }
        public byte S { get; set; }
        public byte V { get; set; }

        public HSV(int h, byte s, byte v)
        {
            this.H = h;
            this.S = s;
            this.V = v;
        }

        public override bool Equals(object obj)
        {
            var result = (HSV)obj;

            return (
                result != null &&
                this.H == result.H &&
                this.S == result.S &&
                this.V == result.V);
        }

        public override string ToString()
        {
            return $"{this.H}° {this.S}% {this.V}%";
        }
    }
}