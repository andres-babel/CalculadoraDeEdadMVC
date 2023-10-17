using CalculadoraDeEdadMVC.Models;
using CalculadoraDeEdadMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Controllers
{
    internal class FutureAgeController
    {
        private List<UserModel> Users;
        private FutureAgeMenuView MenuView;
        private DateTime FutureDate;
        public FutureAgeController(List<UserModel> users) 
        {
            Users = users;
            MenuView = new FutureAgeMenuView();
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
                        case 1: AddFutureDate(); break;
                        case 2: ShowUsersFutureAge(); break;
                    }
                }
            }
        }


        private void AddFutureDate() 
        {
            bool exec = true;
            while (exec)
            {
                FutureDate = MenuView.GetUserFutureDate();
                if (!isValid(FutureDate))
                    exec = false;
                else
                    Console.WriteLine("Wrong Future Date");
            }   
        }

        private bool isValid(DateTime futureDate)
        {
            foreach (var user in Users)
            {
                int comp = DateTime.Compare(user.BirthDate, futureDate);
                if (comp >= 0)
                    return true;
            }

            return false;

        }

        private void ShowUsersFutureAge()
        {
            foreach (UserModel user in Users)
            {
                AgeModel age = user.CalculateFutureAge(FutureDate);
                MenuView.ShowUserFutureAge(user.Name, age.Years.ToString());
            }
        }


    }
}
