using System;
using System.Collections.Generic;

namespace XmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // 1. Scenario
                IEnumerable<IXmlNode> xmlStream = new IXmlNode[]
                {
                new StartingElement("config"),
                new StartingElement("site"),
                new StartingElement("host"),
                new InnerText("192.168.0.1"),
                new EndElement("host"),
                new StartingElement("host"),
                new InnerText("192.168.0.2"),
                new EndElement("host"),
                new StartingElement("host"),
                new InnerText("192.168.0.3"),
                new EndElement("host"),
                new EndElement("site"),
                new StartingElement("site"),
                new StartingElement("host"),
                new InnerText("10.0.0.1"),
                new EndElement("host"),
                new EndElement("site"),
                new EndElement("config")
                };

                var visitor = new XmlValidatorVisitor();
                var visitor2 = new CollectingHostAddressVisitor();
                foreach (var node in xmlStream)
                {
                    node.Accept(visitor);
                    node.Accept(visitor2);
                }

                Console.WriteLine($"XML IsValid: {visitor.IsValid}");
                Console.WriteLine(string.Join(", ", visitor2.Result));
            }
            {
                // 2. Scenario
                IEnumerable<Polymorphic.IXmlNode> xmlStream = new Polymorphic.IXmlNode[]
                {
                new Polymorphic.StartingElement("config"),
                new Polymorphic.StartingElement("site"),
                new Polymorphic.StartingElement("host"),
                new Polymorphic.InnerText("192.168.0.1"),
                new Polymorphic.EndElement("host"),
                new Polymorphic.StartingElement("host"),
                new Polymorphic.InnerText("192.168.0.2"),
                new Polymorphic.EndElement("host"),
                new Polymorphic.StartingElement("host"),
                new Polymorphic.InnerText("192.168.0.3"),
                new Polymorphic.EndElement("host"),
                new Polymorphic.EndElement("site"),
                new Polymorphic.StartingElement("site"),
                new Polymorphic.StartingElement("host"),
                new Polymorphic.InnerText("10.0.0.1"),
                new Polymorphic.EndElement("host"),
                new Polymorphic.EndElement("site"),
                new Polymorphic.EndElement("config")
                };

                foreach (var node in xmlStream)
                {
                    node.Mark();
                }

                Console.WriteLine($"XML IsValid: {Polymorphic.StartingElement.Count == Polymorphic.EndElement.Count}");
            }
        }
    }
}
