using CalculadoraDeEdadMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Views
{
    internal class MenuView
    {

        public void DisplayMenu()
        {
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("1) Add User");
            Console.WriteLine("2) Show Users Age");
            Console.WriteLine("0) Exit\n");
            Console.Write("Choice: ");
        }

        public string GetUserName()
        {
            bool valid = false;
            string name = string.Empty;

            while (!valid)
            {
                Console.Write("Write Name: ");
                name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name))
                    valid = true;
                else
                    Console.WriteLine("Non valid name\n");
            }
            return name;
        }

        public DateTime GetUserBirthDate()
        {
            bool valid = false;
            string userInput;
            DateTime userBirthDate = new DateTime();

            while (!valid)
            {
                Console.Write("\nWrite your Date of Birth (dd/mm/aaaa): ");
                userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) && DateTime.TryParseExact(userInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDate))
                {
                    valid = true;
                    userBirthDate = birthDate;
                }
                else
                    Console.WriteLine("Non valid birthdate\n");
            }

            return userBirthDate;
        }

        public void ShowUserAge(string username, string years, string months, string days)
        {
            Console.Write("\n{0} is {1} Years, {2} Months, and {3} Days Old\n", username, years, months, days);
        }

    }
}
