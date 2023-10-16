

using CalculadoraDeEdadMVC.Controllers;

namespace CalculadoraDeEdadMVC
{
    public class Program
    {
       public static void Main()
        {
            MenuController menuController = new MenuController();
            menuController.ManageMenu();
        }
    }
}
