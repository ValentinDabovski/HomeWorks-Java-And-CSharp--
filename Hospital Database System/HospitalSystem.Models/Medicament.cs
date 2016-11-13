using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Models
{
    public class Medicament
    {
        private ICollection<Patient> patients;

        public Medicament()
        {
            this.patients = new HashSet<Patient>();
        }

        [Key]
        public int Id { get; set; }

       
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Patient> Patients
        {
            get { return this.patients; }
            set { this.patients = value;}
        }
    }
}
