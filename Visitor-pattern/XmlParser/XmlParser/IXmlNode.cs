namespace XmlParser
{
    internal interface IXmlNode
    {
        void Accept(IXmlVisitor visitor);
    }
}
