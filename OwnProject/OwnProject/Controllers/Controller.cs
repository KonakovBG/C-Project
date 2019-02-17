using OwnProject.Models;
using OwnProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProject.Controllers
{
    public class Controller
    {
        private Display display;
        private VacationModel vacation;

        public Controller()
        {
            display = new Display();
            vacation = new VacationModel(display.Budget, display.Season);
        }

        public void StartUp()
        {            
            display.Country = vacation.Country;
            display.Accomodation = vacation.Accomodation;

            display.Price = vacation.CalculatePrice();
            display.Print();
                
        }
        
    }
}
