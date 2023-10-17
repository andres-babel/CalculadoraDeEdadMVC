using CalculadoraDeEdadMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Views
{
    internal class FutureAgeMenuView
    {
        public void DisplayMenu()
        {
            Console.WriteLine("\nFuture Menu Options: ");
            Console.WriteLine("1) Set Future Date");
            Console.WriteLine("2) Show Users Future Age");
            Console.WriteLine("0) Exit\n");
            Console.Write("Choice: ");
        }

        public DateTime GetUserFutureDate()
        {
            bool valid = false;
            string userInput;
            DateTime futureDate = new DateTime();

            while (!valid)
            {
                Console.Write("\nWrite Future Date (dd/mm/aaaa): ");
                userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) && DateTime.TryParseExact(userInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime newDate))
                {
                    valid = true;
                    futureDate = newDate;
                }
                else
                    Console.WriteLine("Non valid future date\n");
            }

            return futureDate;
        }

        public void ShowUserFutureAge(string username, string years)
        {
            Console.Write("\n{0} will be {1} Years Old\n", username, years);
        }

    }
}
