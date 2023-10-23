using CalculadoraDeEdadMVC.Models;
using CalculadoraDeEdadMVC.Service;
using CalculadoraDeEdadMVC.Views;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Controllers
{
    internal class MenuController
    {
        private List<UserModel> Users;
        private MenuView MenuView;
        private List<PlanetConfiguration> PlanetsConfig;
        private AgeCalculatorService Service;
        public MenuController(IConfiguration config) 
        {
            Users = new List<UserModel>();
            MenuView = new MenuView();
            PlanetsConfig = SetPlanets(config);
            Service = new AgeCalculatorService(PlanetsConfig);
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
                        case 1: AddUser(); break;
                        case 2: ChangeUserName(); break;
                        case 3: ShowUsersAge(); break;   
                        case 4: new AgeController(Users,Service).ManageMenu(); break;
                        case 5: new AgeInPlanetsController(Users, Service).ManageMenu(); break;
                        case 6: new FutureAgeController(Users,Service).ManageMenu(); break;
                    }
                }
            }
        }

        private void AddUser()
        {
            string username = MenuView.GetUserName();
            DateTime birthDate = MenuView.GetUserBirthDate();

            Users.Add(new UserModel(username, birthDate));
        }

        private List<PlanetConfiguration> SetPlanets(IConfiguration config)
        {
            List<PlanetConfiguration> planetConfigurations = new List<PlanetConfiguration>();

            var planetsData = config.GetSection("Planets");

            foreach (var item in planetsData.GetChildren())
            {
                var option = item["Number"];
                var name = item["Name"];
                var orbital = item["Orbit"];

                if(!string.IsNullOrEmpty(option) && !string.IsNullOrEmpty(orbital) && !string.IsNullOrEmpty(name)) 
                    planetConfigurations.Add(new PlanetConfiguration(int.Parse(option),name, double.Parse(orbital)));

            }
            return planetConfigurations;
        }


        private void ChangeUserName()
        {
            Users = MenuView.ChangeUser(Users);
            
        }


        private void ShowUsersAge()
        {
            foreach (UserModel user in Users)
            {
                AgeModel age = Service.CalculateAgeInYearsMonthsAndDays(user.BirthDate);
                MenuView.ShowUserAge(user.Name, age.Years.ToString(), age.Months.ToString(), age.Days.ToString());
            }
        }


    }
}
