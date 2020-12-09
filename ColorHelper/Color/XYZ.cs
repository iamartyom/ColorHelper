namespace ColorHelper
{
    public class XYZ : IColor
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public XYZ(float x, float y, float z)
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