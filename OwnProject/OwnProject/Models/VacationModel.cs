using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProject.Models
{
    public class VacationModel
    {
        public double Budget { get; set; }

        public string Season { get; set; }

        public string Country { get; set; }

        public string Accomodation { get; set; }

        public double Price { get; set; } = 0;

        public VacationModel(double budget, string season)
        {
            this.Budget = budget;
            this.Season = season;
        }

        public double CalculatePrice()
        {           
            if(Budget <= 100)
            {
                if(Season == "summer")
                {
                    this.Price = Budget * (30 / 100);
                    Accomodation = "Camp";
                    Country = "Somewhere in Bulgaria";                   
                }
                else
                {
                    Accomodation = "Hotel";
                    Country = "Somewhere in Bulgaria";
                    Price = Budget * (70 / 100);
                }
            }
            if (Budget <= 1000 && Budget > 100)
            {
                if (Season == "summer")
                {
                    Accomodation = "Camp";
                    Country = "Somewhere in Balkans";
                    Price = Budget * (40 / 100);
                }
                else
                {
                    Accomodation = "Hotel";
                    Country = "Somewhere in Balkans";
                    Price = Budget * (80 / 100);
                }
            }
            if (Budget > 1000)
            {
                    Accomodation = "Hotel";
                    Country = "Somewhere in Europe";
                    Price = Budget * (90 / 100);
            }

            return Price;
        }
    }
}
