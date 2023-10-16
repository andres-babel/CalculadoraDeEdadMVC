using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeEdadMVC.Models
{
    internal class AgeModel
    {
        public int Years { set; get; }
        public int Months { set; get; }
        public int Days { set; get; }

        public int AgeInMonths { set; get; }
        public int AgeInDays { set; get; }


        public AgeModel(int ageYears, int ageMonths, int ageDays)
        {
            Years = ageYears;
            Months = ageMonths;
            Days = ageDays;
            AgeInMonths = 0;
            AgeInDays = 0;
        }

    }
}
