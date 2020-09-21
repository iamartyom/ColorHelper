namespace ColorHelper
{
    public class HEX : IColor
    {
        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = (value.IndexOf('#') == 0) ? value.Substring(1) : value; }
        }

        public HEX(string value)
        {
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            return this.Value == (obj as HEX)?.Value;
        }

        public override string ToString()
        {
            return $"{this.Value}";
        }
    }
}