using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2KOLKIT.Models
{
    public class Absence
    {
        [Key]
        public int AbsenceId { get; set; }
        public string Description { get; set; }

        public Boolean isApproved { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Absence()
        {
            isApproved = false;
        }

        
    }
}