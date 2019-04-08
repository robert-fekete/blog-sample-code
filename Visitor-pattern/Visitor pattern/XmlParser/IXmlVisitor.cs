namespace XmlParser
{
    internal interface IXmlVisitor
    {
        void Visit(StartingElement element);
        void Visit(EndElement end);
        void Visit(InnerText text);
    }
}