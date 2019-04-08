namespace XmlParser
{
    internal class Element : IXmlNode
    {
        public Element(string tag)
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
