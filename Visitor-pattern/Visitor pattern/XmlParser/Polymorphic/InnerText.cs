namespace XmlParser.Polymorphic
{
    internal class InnerText : IXmlNode
    {
        public InnerText(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public void Mark()
        {
            // No op
        }
    }
}
