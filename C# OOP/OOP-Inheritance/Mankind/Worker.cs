using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Char;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal salary;
        private int workingHour;

        public Worker(string firstName, string lastName,decimal salary,int workingHour) : base(firstName, lastName)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            this.WorkingHour = workingHour;
            this.Salary = salary;
        }

        public decimal Salary {
            get
            {
                return this.salary;
                
            }
            set
            {
                if (value < 10)
                {
                    throw new  ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }
        public int WorkingHour {
            get
            {
                return this.workingHour;
                
            }
            set
            {
                if (value < 1 && value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHour = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"First Name: {base.FirstName}{Environment.NewLine}");
            stringBuilder.Append($"Last Name: {base.LastName}{Environment.NewLine}");
            stringBuilder.Append($"Week Salary: {this.salary:F2}{Environment.NewLine}");
            stringBuilder.Append($"Hours per day: {this.workingHour:F2}{Environment.NewLine}");
            stringBuilder.Append($"Salary per hour: {(this.salary/workingHour)/5:F2}");

            return stringBuilder.ToString();
        }
    }
}

