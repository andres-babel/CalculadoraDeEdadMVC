using CalculadoraDeEdadMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Service
{
    internal class AgeCalculatorService
    {

        private List<PlanetConfiguration> PlanetsConfiguration;

        public AgeCalculatorService(List<PlanetConfiguration> planetsConfiguration) {
            PlanetsConfiguration = planetsConfiguration;
        }

        public List<PlanetConfiguration> getPlanetsConfiguration() {  return PlanetsConfiguration; }


        public AgeModel CalculateAgeInYearsMonthsAndDays(DateTime BirthDate)
        {
            DateTime today = DateTime.Today;

            int ageYears = today.Year - BirthDate.Year;
            int ageMonths = today.Month - BirthDate.Month;
            int ageDays = today.Day - BirthDate.Day;

            AgeModel age = new AgeModel(ageYears, ageMonths, ageDays);


            if (age.Days < 0)
            {
                age.Months--;
                int lastDayPrevMonth = DateTime.DaysInMonth(today.Year, today.Month - 1);
                age.Days += lastDayPrevMonth;
            }

            if (age.Months < 0)
            {
                age.Years--;
                age.Months += 12;
            }

            return age;
        }


        public AgeModel CalculateAgeInMonthsOrDays(DateTime BirthDate)
        {
            DateTime today = DateTime.Today;

            AgeModel userAge = CalculateAgeInYearsMonthsAndDays(BirthDate);

            int ageInDays = (int)today.Subtract(BirthDate).TotalDays;
            int ageInMonths = ageInDays / 30;

            userAge.AgeInDays = ageInDays;
            userAge.AgeInMonths = ageInMonths;

            return userAge;
        }



        private double getAgeInPlanet(int age, int choice)
        {

            double orbit = 1;

            foreach (var p in PlanetsConfiguration) {
                if (choice == p.Option)
                    orbit = p.Orbital;
            }

            return orbit * age;

        }


        private string getPlanet(int choice)
        {

            foreach (var p in PlanetsConfiguration)
            {
                if (choice == p.Option)
                    return p.Name;
            }

            return String.Empty;
        }


        public double CalculateAgeInOtherPlanets(DateTime BirthDate, int choice)
        {
            AgeModel age = CalculateAgeInYearsMonthsAndDays(BirthDate);
            return getAgeInPlanet(age.Years, choice);

        }

        public string getPlanetChoice(int choice)
        {
            return getPlanet(choice);
        }


        public AgeModel CalculateFutureAge(DateTime BirthDate, DateTime futureDate)
        {
            int ageYears = futureDate.Year - BirthDate.Year;
            int ageMonths = futureDate.Month - BirthDate.Month;
            int ageDays = futureDate.Day - BirthDate.Day;

            AgeModel age = new AgeModel(ageYears, ageMonths, ageDays);

            if (age.Days < 0)
            {
                age.Months--;
                int lastDayPrevMonth = DateTime.DaysInMonth(futureDate.Year, futureDate.Month - 1);
                age.Days += lastDayPrevMonth;
            }

            if (age.Months < 0)
            {
                age.Years--;
                age.Months += 12;
            }

            return age;

        }

    }
}
