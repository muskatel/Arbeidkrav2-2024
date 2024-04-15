// See https://aka.ms/new-console-template for more information

using System.Text;
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

StringBuilder shoppingList = new StringBuilder();
shoppingList.Append("Shopping List\n\n");
//Console.WriteLine("Loaded packages:");

foreach (Package p in pc.packages)
{
    //Console.WriteLine(p.ToString());
    shoppingList.Append("ITEM: " + p);
    shoppingList.Append("\n");
    
    // Spec-2: Find best packing option
    Packing pack = new Packing(p);
    //Console.WriteLine(pack);
    shoppingList.Append("Packing Option: " + pack);
    shoppingList.Append("\n");
    
    // Spec-3: Find the best postage option
    Postage post = new Postage(pack);
    //Console.WriteLine(post);
    shoppingList.Append("Postage Option: " + post);
    shoppingList.Append("\n");
    
    //Console.WriteLine("");
    
    shoppingList.Append("\n");
}

// Spec-4: Output shopping list -> file
StreamWriter sw = new StreamWriter("shoppinglist.txt");
sw.Write(shoppingList.ToString());
sw.Close();


// Spec-5: Readme and other docs 