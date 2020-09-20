namespace ColorHelper.Color
{
    public class HEX
    {
        public string Value { get; set; }

        public HEX(string value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value}";
        }
    }
}