using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationPortel_3Octover26.Models
{
    public class tblGender
    {
        [Key]
        public int GenderId { get; set; }
        public string GenderName { get; set; }
    }
}