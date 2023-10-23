using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Models
{
    internal class PlanetConfiguration
    {
        public int Option {  get; set; }
        public string Name { get; set; }
        public double Orbital {  get; set; }

        public PlanetConfiguration(int option, string name, double orbital) {
        
            Option = option;
            Name = name;
            Orbital = orbital;
        }

    }
}
