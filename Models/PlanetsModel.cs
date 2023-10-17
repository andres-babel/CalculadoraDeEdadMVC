using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Models
{
    internal class PlanetsModel
    {

        public static List<string> Planets = new List<string>()
        {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Pluto"
        };


        private Dictionary<string, double> AgeInPlanets = new Dictionary<string, double>();

        private Dictionary<string, double> AgeInPlanetsConstants = new Dictionary<string, double>() 
        {
            {"Mercury", 0.240},
            {"Venus", 0.615},
            {"Earth", 1},
            {"Mars", 1.880},
            {"Jupiter", 11.863},
            {"Saturn", 29.447},
            {"Uranus", 84.017},
            {"Neptune", 164.791},
            {"Pluto", 248.090}
        };


        public void setAgeInPlanets(int age)
        {
            foreach (var planet in Planets)
                AgeInPlanets[planet] = age * AgeInPlanetsConstants[planet];

        }

        public double getAgeInPlanet(string planet)
        {
            return AgeInPlanets[planet];
        }

    }
}
