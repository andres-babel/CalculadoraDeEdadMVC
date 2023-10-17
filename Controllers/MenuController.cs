﻿using CalculadoraDeEdadMVC.Models;
using CalculadoraDeEdadMVC.Views;
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
        public MenuController() 
        {
            Users = new List<UserModel>();
            MenuView = new MenuView();
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
                        case 4: new AgeController(Users).ManageMenu(); break;
                        case 5: new AgeInPlanetsController(Users).ManageMenu(); break;
                        case 6: new FutureAgeController(Users).ManageMenu(); break;
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

        private void ChangeUserName()
        {
            Users = MenuView.ChangeUser(Users);
            
        }


        private void ShowUsersAge()
        {
            foreach (UserModel user in Users)
            {
                AgeModel age = user.CalculateAgeInYearsMonthsAndDays();
                MenuView.ShowUserAge(user.Name, age.Years.ToString(), age.Months.ToString(), age.Days.ToString());
            }
        }


    }
}
