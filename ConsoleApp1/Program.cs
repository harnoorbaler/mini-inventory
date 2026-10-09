using System.Xml;
using System.Xml.Serialization;

karaktär minkar = new();

minkar.Ryggsäck.Display();

rustning hjälm = new rustning() { namn = "brons hjälm", vikt = 3f };

Console.WriteLine($"du har hittat en {hjälm.namn}. plocka upp den? [ja/nej]");

string val = "";
while (val != "ja" && val != "nej")
{
    val = Console.ReadLine().ToLower();
}
if (val == "ja")
{
    Console.WriteLine("lägger in det i ditt inventory ");
    minkar.Ryggsäck.objekt.Add(hjälm);
}
else
{
    Console.WriteLine("hoppar över den");
}
Console.WriteLine("Ditt inventory är nu");
minkar.Ryggsäck.Display();
Console.ReadLine();