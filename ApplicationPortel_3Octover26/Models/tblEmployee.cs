using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ApplicationPortel_3Octover26.Models
{
    public class tblEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeResume { get; set; }
    }
}