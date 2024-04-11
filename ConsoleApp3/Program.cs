using System;
using System.Text.Json;
using Newtonsoft.Json;
using System;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Linq;
using Nancy.Json;



string data = @" [ {""name"": ""John Doe"", ""occupation"": ""gardener""}, 
    {""name"": ""Peter Novak"", ""occupation"": ""driver""} ]";

using JsonDocument doc = JsonDocument.Parse(data);
JsonElement root = doc.RootElement;

Console.WriteLine(root);

var u1 = root[0];
var u2 = root[1];
Console.WriteLine(u1);
Console.WriteLine(u2);

Console.WriteLine(u1.GetProperty("name"));
Console.WriteLine(u1.GetProperty("occupation"));

Console.WriteLine(u2.GetProperty("name"));
Console.WriteLine(u2.GetProperty("occupation"));
//////////////////////////////////////////////////////////////
var xml = XDocument.Load(JsonReaderWriterFactory.CreateJsonReader(
    Encoding.ASCII.GetBytes(data), new XmlDictionaryReaderQuotas()));


Console.WriteLine("JSON to XML");
Console.WriteLine(xml);
Console.WriteLine();
Console.WriteLine();



