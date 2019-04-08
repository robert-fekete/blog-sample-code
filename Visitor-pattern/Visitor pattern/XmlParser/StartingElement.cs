namespace XmlParser
{
    internal class StartingElement : IXmlNode
    {
        public StartingElement(string tag)
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
