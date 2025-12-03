using CookBookCLI.Menu;
using CookBookCLI.Menu.MenuOptions;

var options = new List<IMenuOption>
{
    new ListOption(),
};

var menu = new Menu(options);
menu.start();