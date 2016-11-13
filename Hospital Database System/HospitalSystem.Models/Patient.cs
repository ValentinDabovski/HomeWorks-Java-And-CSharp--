using System.Text.RegularExpressions;

namespace HospitalSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    public class Patient
    {
        private ICollection<Visitation> visitationId;
        private ICollection<Diagnose> diagnoseId;
        private ICollection<Medicament> medicamentId;

        public Patient()
        {
            this.visitationId = new HashSet<Visitation>();
            this.diagnoseId = new HashSet<Diagnose>();
            this.medicamentId = new HashSet<Medicament>();

        }

        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }


        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }


        [MaxLength(100)]
        public string Address { get; set; }


        [RegularExpression(@"\A[^@]+@([^@\.]+\.)+[^@\.]+\z")]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(1024 * 1024)]
        public byte[] ProfilePicture { get; set; }

        [Required]
        public bool HasmedicalInsurance { get; set; }

        public virtual ICollection<Visitation> VisitationId
        {
            get { return this.visitationId; }
            set { this.visitationId = value; }
        }

        public virtual ICollection<Diagnose> DiagnoseId
        {
            get { return this.diagnoseId; }
            set { this.diagnoseId = value; }
        }

        public virtual ICollection<Medicament> MedicamentId
        {
            get { return this.medicamentId; }
            set { this.medicamentId = value; }
        }
    }
}
