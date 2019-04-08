namespace XmlParser.Polymorphic
{
    internal class StartingElement : IXmlNode
    {
        public static int Count = 0;

        public StartingElement(string tag)
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
