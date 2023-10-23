using CalculadoraDeEdadMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Models
{
    internal class UserModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public UserModel(string name, DateTime birthDate) 
        {
            Name = name;
            BirthDate = birthDate;
        }


    }
}
