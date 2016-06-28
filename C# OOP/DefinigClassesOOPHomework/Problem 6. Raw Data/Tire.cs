using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Raw_Data
{
    class Tire
    {
        private double tirePresure;
        private int tireAge;
        
        public Tire(double tirePresure,int tireAge)
        {
            this.tirePresure = tirePresure;
            this.tireAge = tireAge;
        }

        public double TirePresure => tirePresure;
        public int TireAge => tireAge;
    }
}
