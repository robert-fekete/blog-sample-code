namespace XmlParser
{
    internal class EndElement : IXmlNode
    {
        public EndElement(string tag)
        {
            Tag = tag;
        }

        public string Tag { get; }

        public void Accept(IXmlVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
