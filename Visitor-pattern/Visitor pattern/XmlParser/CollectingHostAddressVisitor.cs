using System.Collections.Generic;

namespace XmlParser
{
    internal class CollectingHostAddressVisitor : IXmlVisitor
    {
        public List<string> Result { get; } = new List<string>();
        public bool saveText = false;

        public void Visit(StartingElement element)
        {
            if (element.Tag == "host")
            {
                saveText = true;
            }
        }

        public void Visit(EndElement end)
        {
            saveText = false;
        }

        public void Visit(InnerText text)
        {
            Result.Add(text.Value);
        }
    }
}
