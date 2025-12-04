using CookBookCLI.Menu;
using CookBookCLI.Menu.MenuOptions;
using CookBookCLI.Models;
using CookBookCLI.Storage;
using SearchOption = CookBookCLI.Menu.MenuOptions.SearchOption;

var storage = new RecipeStorage("recipes.json");

var options = new List<IMenuOption>
{
    new ListOption(storage),
    new CreateOption(storage),
    new SearchOption(storage),
    new EditOption(storage),
};

var menu = new Menu(options);
menu.start();

//var testRecipes = new List<Recipe>
//{
//    new Recipe
//    {
//        Name = "Tészta paradicsomszósszal",
//        Description = "Egyszerű és gyors tészta paradicsomszósszal.",
//        PreparationTimeInMinutes = 20,
//        Ingredients = new List<Ingredient>
//        {
//            new Ingredient { Name = "Tészta", Quantity = 200, Unit = "g" },
//            new Ingredient { Name = "Paradicsomszósz", Quantity = 150, Unit = "ml" },
//            new Ingredient { Name = "Olívaolaj", Quantity = 2, Unit = "evőkanál" },
//            new Ingredient { Name = "Fokhagyma", Quantity = 2, Unit = "gerezd" },
//            new Ingredient { Name = "Só", Quantity = 1, Unit = "csipet" },
//            new Ingredient { Name = "Bors", Quantity = 1, Unit = "csipet" }
//        }
//    },
//    new Recipe
//    {
//        Name = "Rántotta",
//        Description = "Klasszikus rántotta vajjal és zöldhagymával.",
//        PreparationTimeInMinutes = 10,
//        Ingredients = new List<Ingredient>
//        {
//            new Ingredient { Name = "Tojás", Quantity = 3, Unit = "db" },
//            new Ingredient { Name = "Vaj", Quantity = 20, Unit = "g" },
//            new Ingredient { Name = "Zöldhagyma", Quantity = 1, Unit = "szál" },
//            new Ingredient { Name = "Só", Quantity = 1, Unit = "csipet" },
//            new Ingredient { Name = "Bors", Quantity = 1, Unit = "csipet" }
//        }
//    }
//};

//await storage.SaveRecipes(testRecipes);
//var loadedRecipes = await storage.LoadRecipes();
//Console.WriteLine(loadedRecipes);
