
using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Visitation
    {
        private ICollection<Patient> patients;
        public Visitation()
        {
            this.patients = new HashSet<Patient>();
        }

        [Key]
        public int Id { get; set; }
        
       
        public DateTime Date { get; set; }

        [MaxLength(500)]
        public string Comments { get; set; }

        public virtual ICollection<Patient> Patients
        {
            get { return this.patients; }

            set { this.patients = value; }
        }
    }
}
