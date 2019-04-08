namespace XmlParser
{
    internal class Text : IXmlNode
    {
        public Text(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public void Accept(IXmlVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
