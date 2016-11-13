using HospitalSystem.Models;

namespace HospitalSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HospitalContext : DbContext
    {
       
        public HospitalContext()
            : base("name=HospitalContext")
        {
        }

        public IDbSet<Patient> Patients { get; set; }

        public IDbSet<Medicament> Medicaments { get; set; }

        public IDbSet<Diagnose> Diagnoses { get; set; }

        public IDbSet<Visitation> Visitations { get; set; }

    }

}