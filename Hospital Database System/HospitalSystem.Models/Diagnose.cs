using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Models
{
    public class Diagnose
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Comments { get; set; }
    }
}
