using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Views
{
    internal class AgeFormatsMenuView
    {

        public void DisplayMenu()
        {
            Console.WriteLine("\nAge Format Menu Options: ");
            Console.WriteLine("1) Show Users Age in Months");
            Console.WriteLine("2) Show Users Age in Days");
            Console.WriteLine("3) Show Users Age in Months or Days");
            Console.WriteLine("4) Show Users Age in Years, Months or Days");
            Console.WriteLine("0) Exit\n");
            Console.Write("Choice: ");
        }


        public void showUsersAgeInMonths(string username, string months)
        {
            Console.Write("\n{0} is {1} Months Old\n", username, months);
        }
        
        public void showUsersAgeInDays(string username, string days)
        {
            Console.Write("\n{0} is {1} Days Old\n", username, days);
        }
              
        public void showUsersAgeInMonthsOrDays(string username, string months, string days)
        {
            Console.Write("\n{0} is {1} Months or {2} Days Old\n", username, months, days);
        }
                      
        public void showUsersAgeInYearsMonthsOrDays(string username, string years, string months, string days)
        {
            Console.Write("\n{0} is {1} Years, {2} Months, or {3} Days Old\n", username, years, months, days);
        }






    }
}
