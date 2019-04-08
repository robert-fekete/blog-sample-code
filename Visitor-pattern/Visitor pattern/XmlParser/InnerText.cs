namespace XmlParser
{
    internal class InnerText : IXmlNode
    {
        public InnerText(string value)
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
