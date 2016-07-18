using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
    public class City : ICity
    {
        private List<IChekable> robotsAndCitizens;
        
        public City()
        {
            this.robotsAndCitizens = new List<IChekable>();
        }

        public void AddCitizen(IChekable citizen)
        {
            this.robotsAndCitizens.Add(citizen);
        }
        
        public IEnumerable<IChekable> Citizens
        {
            get { return this.robotsAndCitizens; }
        }
        
        public void RemoveCitizen(IChekable citizen)
        {
            this.robotsAndCitizens.Remove(citizen);
        }
    }
}
