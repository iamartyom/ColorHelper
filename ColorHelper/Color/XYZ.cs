namespace ColorHelper
{
    public class XYZ : IColor
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public XYZ(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override bool Equals(object obj)
        {
            var result = (XYZ)obj;

            return (
                result != null &&
                this.X == result.X &&
                this.Y == result.Y &&
                this.Z == result.Z);
        }

        public override string ToString()
        {
            return $"{this.X} {this.Y} {this.Z}";
        }
    }
}