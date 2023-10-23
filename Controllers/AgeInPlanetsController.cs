using CalculadoraDeEdadMVC.Models;
using CalculadoraDeEdadMVC.Service;
using CalculadoraDeEdadMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Controllers
{
    internal class AgeInPlanetsController
    {
        private List<UserModel> Users;
        private AgeInPlanetsMenuView MenuView;
        private AgeCalculatorService Service;
        public AgeInPlanetsController(List<UserModel> users, AgeCalculatorService Service)
        {
            Users = users;
            MenuView = new AgeInPlanetsMenuView();
            this.Service = Service;
        }


        public void ManageMenu()
        {
            int choice = 0;
            bool exec = true;

            while (exec)
            {
                MenuView.DisplayMenu(Service.getPlanetsConfiguration());
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 0: exec = false; break;
                        default: ShowUsersAgeInPlanet(choice); break;
                    }
                }
            }
        }


        private void ShowUsersAgeInPlanet(int choice)
        {

            foreach (UserModel user in Users)
            {
                double planetAge = Service.CalculateAgeInOtherPlanets(user.BirthDate, choice);
                string chosenPlanet = Service.getPlanetChoice(choice);
                MenuView.ShowAgeInPlanet(user.Name, planetAge.ToString(), chosenPlanet);
            }
        }

    }
}
