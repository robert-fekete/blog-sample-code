namespace XmlParser.Polymorphic
{
    internal class EndElement : IXmlNode
    {
        public static int Count = 0;
        public EndElement(string tag)
        {
            Tag = tag;
        }

        public string Tag { get; }
        
        public void Mark()
        {
            Count++;
        }
    }
}
