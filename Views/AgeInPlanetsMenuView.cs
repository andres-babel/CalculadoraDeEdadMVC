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

        public void DisplayMenu()
        {
            Console.WriteLine("\nPlanet Menu Options: ");
            for (int i = 0; i < PlanetsModel.Planets.Count; i++)
                Console.WriteLine("{0}) Show Users Age in {1}",i+1, PlanetsModel.Planets[i]);
            
            Console.WriteLine("0) Exit\n");
            Console.Write("Choice: ");
        }


        public void ShowAgeInPlanet(string username, string age, string planet)
        {
            Console.WriteLine("\n{0} has {1} Years In {2}", username, age, planet);
        }



    }
}
