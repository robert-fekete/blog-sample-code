namespace XmlParser
{
    internal class XmlValidatorVisitor : IXmlVisitor
    {
        private int elements = 0;
        private int endEmelents = 0;

        public bool IsValid => elements == endEmelents;

        public void Visit(StartingElement element)
        {
            elements++;
        }

        public void Visit(EndElement end)
        {
            endEmelents++;
        }

        public void Visit(InnerText text)
        {
            // No op
        }
    }
}
