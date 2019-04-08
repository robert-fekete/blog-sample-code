using System;
using System.Collections.Generic;

namespace XmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IXmlNode> xmlStream = new IXmlNode[]
            {
                new Element("config"),
                new Element("site"),
                new Element("host"),
                new Text("192.168.0.1"),
                new EndElement("host"),
                new Element("host"),
                new Text("192.168.0.2"),
                new EndElement("host"),
                new Element("host"),
                new Text("192.168.0.3"),
                new EndElement("host"),
                new EndElement("site"),
                new Element("site"),
                new Element("host"),
                new Text("10.0.0.1"),
                new EndElement("host"),
                new EndElement("site"),
                new EndElement("config")
            };

            var visitor = new XmlValidatorVisitor();
            var visitor2 = new CollectingHostAddressVisitor();
            foreach(var node in xmlStream)
            {
                node.Accept(visitor);
                node.Accept(visitor2);
            }

            Console.WriteLine($"XML IsValid: {visitor.IsValid}");
            Console.WriteLine(string.Join(", ", visitor2.Result));
        }
    }
}
