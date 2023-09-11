using System;
using System.Linq;

namespace GuitarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            // Add guitars to the inventory
            inventory.AddGuitar("12345", 1000.0, Builder.Fender, "Stratocaster", Type.Electric, BackWood.Maple, TopWood.Maple);
            inventory.AddGuitar("67890", 1500.0, Builder.Martin, "D-28", Type.Acoustic, BackWood.Rosewood, TopWood.Cedar);

            Console.WriteLine("Enter Guitar Details:");

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Type (Acoustic/Electric): ");
            string typeInput = Console.ReadLine();
            Enum.TryParse(typeInput, out Type type);

            Console.Write("Backwood (Mahogany/Maple/Rosewood/Alder): ");
            string backWoodInput = Console.ReadLine();
            Enum.TryParse(backWoodInput, out BackWood backWood);

            Console.Write("Topwood (Spruce/Cedar/Mahogany/Maple): ");
            string topWoodInput = Console.ReadLine();
            Enum.TryParse(topWoodInput, out TopWood topWood);

            Console.Write("Builder (Fender/Gibson/Martin/Taylor/PRS): ");
            string builderInput = Console.ReadLine();
            Enum.TryParse(builderInput, out Builder builder);

            // Create a search guitar specs object
            GuitarSpecs searchSpecs = new GuitarSpecs
            {
                GuitarBuilder = builder,
                Model = model,
                GuitarType = type,
                BackWood = backWood,
                TopWood = topWood
            };

            // Search for guitars in the inventory
            var matchingGuitars = inventory.Search(searchSpecs);

            if (matchingGuitars.Any())
            {
                Console.WriteLine("Found matching guitars:");
                foreach (var guitar in matchingGuitars)
                {
                    Console.WriteLine($"Serial Number: {guitar.SerialNumber}, Price: {guitar.Price}");
                }
            }
            else
            {
                Console.WriteLine("No matching guitars found.");
            }
        }
    }
}
