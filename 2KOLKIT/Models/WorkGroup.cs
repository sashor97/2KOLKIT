using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2KOLKIT.Models
{
    public class WorkGroup
    {
        [Key]
        public int WorkGroupId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Employee> vraboteni { get; set; }
    }
}