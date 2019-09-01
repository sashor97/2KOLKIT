using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2KOLKIT.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [RegularExpression(@"\w{5}")]
        public string Name { get; set; }

        [Range(1,99,ErrorMessage ="Nevalidni godini")]
        public int Age { get; set; }
        [Display(Name="Slika")]
        public string ImgUrl { get; set; }

        public string Pol { get; set; }

        public virtual List<WorkGroup> workGroups { get; set; }

        public List<Absence> Absences { get; set; }

        public Employee()
        {
            Absences = new List<Absence>();
        }
    }
}