namespace XmlParser
{
    internal class XmlValidatorVisitor : IXmlVisitor
    {
        private int elements = 0;
        private int endEmelents = 0;

        public bool IsValid => elements == endEmelents;

        public void Visit(Element element)
        {
            elements++;
        }

        public void Visit(EndElement end)
        {
            endEmelents++;
        }

        public void Visit(Text text)
        {
            // No op
        }
    }
}
