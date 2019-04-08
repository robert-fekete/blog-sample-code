namespace XmlParser
{
    internal class CountingNodesVisitor : IXmlVisitor
    {
        public int Result { get; private set; } = 0;

        public void Visit(Element element)
        {
            Result++;
        }

        public void Visit(EndElement end)
        {
            Result++;
        }

        public void Visit(Text text)
        {
            Result++;
        }
    }
}
