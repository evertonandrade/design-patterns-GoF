using System;
using System.Linq;
using System.Xml.Linq;

namespace Adapter
{
    public class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();

            var xElement = new XElement("Manufacturers");

            var xAttributes = ManufacturerDataProvider.GetData()
                .Select(m => new XElement("Manufacturer",
                        new XAttribute("City", m.City),
                        new XAttribute("Name", m.Name),
                        new XAttribute("Year", m.Year)
                    )
                );

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine("\nPrinting XML Document \n");
            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}