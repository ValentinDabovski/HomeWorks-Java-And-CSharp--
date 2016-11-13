using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Models
{
    public class Diagnose
    {
        private ICollection<Patient> patients;

        public Diagnose()
        {
            this.patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Comments { get; set; }

        public virtual ICollection<Patient> Patients
        {
            get { return this.patients; }
            set { this.patients = value; }
        }
    }
}
