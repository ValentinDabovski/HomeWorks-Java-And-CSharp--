
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
        [Key]
        public int Id { get; set; }
        
       
        public DateTime Date { get; set; }

        [MaxLength(500)]
        public string Comments { get; set; }
    }
}
