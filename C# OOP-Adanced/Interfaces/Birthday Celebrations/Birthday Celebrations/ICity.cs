using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
    public interface ICity
    {
        void AddCitizen(ICheckable citizen);

        IEnumerable<ICheckable> AllCitizens();

        IEnumerable<ICheckable> AllNotEqualBirthDates();

        IEnumerable<ICheckable> AllEqualBirthDayDates();


        void AddNotEqualBirthDates(ICheckable citezBirthDate);

        void AddEqualBirthDate(ICheckable equalCitizenBirthDate);
    }
}
