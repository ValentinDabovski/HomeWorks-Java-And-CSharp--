using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName,string facultyNumber) : base(firstName, lastName)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            this.FacultyNumber = facultyNumber;

        }

        public string FacultyNumber {
            get
            {
                return this.facultyNumber;  
            } 
            set
            {
                if (value.ToCharArray().Length < 5 || value.ToCharArray().Length > 10 )
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                for (int i = 0; i < value.ToCharArray().Length; i++)
                {
                    if (!char.IsLetterOrDigit(value[i]))
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }

                this.facultyNumber = value;
            } 
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"First Name: {base.FirstName}{Environment.NewLine}");
            stringBuilder.Append($"Last Name: {base.LastName}{Environment.NewLine}");
            stringBuilder.Append($"Faculty number: {this.facultyNumber}{Environment.NewLine}");
            return stringBuilder.ToString();
        }
    }
}


