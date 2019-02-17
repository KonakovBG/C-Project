using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProject.Views
{
    public class Display
    {
        public double Budget { get; set; }

        public string Season { get; set; }

        public string Country { get; set; }

        public string Accomodation { get; set; }

        public double Price { get; set; }

        public Display()
        {
            getvalues();
        }
       
        public void getvalues()
        {
            Budget = double.Parse(Console.ReadLine());

            Season = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine(Country);
            Console.WriteLine(Accomodation + " - " + Price);
        }
    }
}
