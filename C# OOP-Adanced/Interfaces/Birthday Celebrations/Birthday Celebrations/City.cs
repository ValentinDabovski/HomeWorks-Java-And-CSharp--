using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
    public class City : ICity
    {
        private List<ICheckable> citiznesList;
        private List<ICheckable> notEquaBirthDateList;
        private List<ICheckable> allEqualBirthDayDates;
        
        public City()
        { 
            this.citiznesList = new List<ICheckable>();
            this.notEquaBirthDateList = new List<ICheckable>();
            this.allEqualBirthDayDates = new List<ICheckable>();
        }

        public void AddCitizen(ICheckable citizen)
        {
          this.citiznesList.Add(citizen);
        }

        IEnumerable<ICheckable> ICity.AllCitizens()
        {
            return this.citiznesList;
        }

        public IEnumerable<ICheckable> AllNotEqualBirthDates()
        {
            return this.notEquaBirthDateList;
        }

        public IEnumerable<ICheckable> AllEqualBirthDayDates()
        {
            return this.allEqualBirthDayDates;
        }


        public void AddNotEqualBirthDates(ICheckable citezBirthDate)
        {
            this.notEquaBirthDateList.Add(citezBirthDate);
        }

        public void AddEqualBirthDate(ICheckable equalCitizenBirthDate)
        {
           this.allEqualBirthDayDates.Add(equalCitizenBirthDate);
        }
    }
}
