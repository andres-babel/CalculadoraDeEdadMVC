﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Models
{
    internal class UserModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public UserModel(string name, DateTime birthDate) 
        {
            Name = name;
            BirthDate = birthDate;
        }

        public AgeModel CalculateAgeInYearsMonthsAndDays()
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


    }
}