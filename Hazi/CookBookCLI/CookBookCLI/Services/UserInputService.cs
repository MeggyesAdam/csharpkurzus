using CookBookCLI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookBookCLI.Services
{
    internal static class UserInputService
    {
        public static Ingredient GetRecipeFromUser()
        {
            var recipeDTO = new RecipeDTO();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(recipeDTO.Name))
                {
                    Console.Write("Add meg a recept címét: ");
                    recipeDTO.Name = Console.ReadLine();
                }
                if (string.IsNullOrWhiteSpace(recipeDTO.Description))
                {
                    Console.Write("Add meg a recept leírását: ");
                    recipeDTO.Name = Console.ReadLine();
                }
                if (recipeDTO.PreparationTimeInMinutes is null)
                {
                    Console.Write("Add meg, hogy mennyi idő elkészíteni a receptet (perc): ");
                    try
                    {
                        int result = int.Parse(Console.ReadLine()!);
                        recipeDTO.PreparationTimeInMinutes = result;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Kérlek számot adj meg! {ex.Message}");
                        continue;
                    }
                }
            }
        }
    }
}
