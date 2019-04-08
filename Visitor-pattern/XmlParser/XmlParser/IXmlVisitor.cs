namespace XmlParser
{
    internal interface IXmlVisitor
    {
        void Visit(Element element);
        void Visit(EndElement end);
        void Visit(Text text);
    }
}