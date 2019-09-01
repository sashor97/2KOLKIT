using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2KOLKIT.Models
{
    public class AddWorkGroup
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public int WorkGroupId { get; set; }
        public List<WorkGroup> workGroups { get; set; }

        public AddWorkGroup()
        {
            workGroups = new List<WorkGroup>();
        }
    }
}