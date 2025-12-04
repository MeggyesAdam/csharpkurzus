using System;
using System.Collections.Generic;
using System.Text;

namespace CookBookCLI.Menu.MenuOptions
{
    internal class CreateOption : IMenuOption
    {
        public string Title => "Új recept hozzáadása";

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("=== Új recept hozzáadása ===");
            Console.Write("Add meg a recept címét: ");
            var title = Console.ReadLine();
            Console.Write("Add meg a recept leírását: ");
            var description = Console.ReadLine();
            Console.Write("Add meg az elkészítési időt (perc): ");
            var preparationTimeInMinutes = 
        }
    }
}
