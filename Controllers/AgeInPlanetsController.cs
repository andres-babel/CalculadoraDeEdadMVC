using CalculadoraDeEdadMVC.Models;
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
        public AgeInPlanetsController(List<UserModel> users)
        {
            Users = users;
            MenuView = new AgeInPlanetsMenuView();
        }


        public void ManageMenu()
        {
            int choice = 0;
            bool exec = true;

            while (exec)
            {
                MenuView.DisplayMenu();
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 0: exec = false; break;
                        case 1: 
                        case 2: 
                        case 3: 
                        case 4: 
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9: ShowUsersAgeInPlanet(choice-1); break;

                    }
                }
            }
        }


        private void ShowUsersAgeInPlanet(int choice)
        {
            string chosenPlanet = PlanetsModel.Planets[choice];

            foreach (UserModel user in Users)
            {
                PlanetsModel planetAge = user.CalculateAgeInOtherPlanets();
                MenuView.ShowAgeInPlanet(user.Name, planetAge.getAgeInPlanet(chosenPlanet).ToString(), chosenPlanet);
            }
        }

    }
}
