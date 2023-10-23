using CalculadoraDeEdadMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Views
{
    internal class AgeInPlanetsMenuView
    {

        public void DisplayMenu(List<PlanetConfiguration> planetsConfiguration)
        {
            Console.WriteLine("\nPlanet Menu Options: ");

            foreach (PlanetConfiguration config in planetsConfiguration)
                Console.WriteLine($"{config.Option}) Show Users Age in {config.Name}");

            Console.WriteLine("0) Exit\n");
            Console.Write("Choice: ");
        }


        public void ShowAgeInPlanet(string username, string age, string planet)
        {
            Console.WriteLine("\n{0} has {1} Years In {2}", username, age, planet);
        }



    }
}
