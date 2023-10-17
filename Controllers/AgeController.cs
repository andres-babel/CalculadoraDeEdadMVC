using CalculadoraDeEdadMVC.Models;
using CalculadoraDeEdadMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Controllers
{

    internal class AgeController
    {
        private List<UserModel> Users;
        private AgeFormatsMenuView MenuView;
       
        public AgeController(List<UserModel> usersList)
        {
            Users = usersList;
            MenuView = new AgeFormatsMenuView();
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
                        case 1: ShowUsersAgeInMonths(); break;
                        case 2: ShowUsersAgeInDays(); break;
                        case 3: ShowUsersAgeInMonthsOrDays(); break;
                        case 4: ShowUsersAgeInYearsMonthsOrDays(); break;
                    }
                }
            }
        }


        private void ShowUsersAgeInMonths()
        {
            foreach (UserModel user in Users)
            {
                AgeModel age = user.CalculateAgeInMonthsOrDays();
                MenuView.showUsersAgeInMonths(user.Name, age.AgeInMonths.ToString());  
            }
        }
        
        private void ShowUsersAgeInDays()
        {
            foreach (UserModel user in Users)
            {
                AgeModel age = user.CalculateAgeInMonthsOrDays();
                MenuView.showUsersAgeInDays(user.Name, age.AgeInDays.ToString());  
            }
        }
                
        private void ShowUsersAgeInMonthsOrDays()
        {
            foreach (UserModel user in Users)
            {
                AgeModel age = user.CalculateAgeInMonthsOrDays();
                MenuView.showUsersAgeInMonthsOrDays(user.Name, age.AgeInMonths.ToString(), age.AgeInDays.ToString());  
            }
        }
                
        private void ShowUsersAgeInYearsMonthsOrDays()
        {
            foreach (UserModel user in Users)
            {
                AgeModel age = user.CalculateAgeInMonthsOrDays();
                MenuView.showUsersAgeInYearsMonthsOrDays(user.Name, age.Years.ToString(),age.AgeInMonths.ToString(), age.AgeInDays.ToString());  
            }
        }



    }
}
