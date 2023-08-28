using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

try
{
    //Loading the XML-file by using the class XElement (LINQ to XML)
    XElement targetFromFile = XElement.Load(@"sma_gentext.xml");

    //Picking the unit with id=42007
    XElement trans_unit = targetFromFile.Descendants().First(node => (string)node.Attribute("id") == "42007");

    //Writing the value of the target element to a file
    TextWriter toTextfile = new StreamWriter("targetValue.txt");
    toTextfile.WriteLine(trans_unit.Element("target").Value);
    toTextfile.Close();
}
catch (Exception)
{
    Console.WriteLine("Something went wrong!");
}

