// See https://aka.ms/new-console-template for more information

using System.Text.Json.Serialization;
using Arbeidskrav2.Post;
using Newtonsoft.Json;

// Spec-1: Read a json file and convert to a collection of packages

String file = "items.json";

PackageCollection pc = new PackageCollection();

try
{
    StreamReader sr = new StreamReader(file);
    pc = JsonConvert.DeserializeObject<PackageCollection>(sr.ReadToEnd());
}
catch (FileNotFoundException e)
{
    Console.WriteLine("File not found.");
}
catch (Exception e)
{
    Console.WriteLine(e);
}

Console.WriteLine("Loaded packages:");
foreach (Package p in pc.packages)
{
    Console.WriteLine(p.ToString());
    
    // Spec-2: Find best packing option
    Packing pack = new Packing(p);
    Console.WriteLine(pack);
    Console.WriteLine("");
}





// Spec-3: Find the best postage option

// Spec-4: Output shopping list -> file

// Spec-5: Readme and other docs 