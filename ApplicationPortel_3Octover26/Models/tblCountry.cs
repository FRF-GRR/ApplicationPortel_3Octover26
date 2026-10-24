using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationPortel_3Octover26.Models
{
    public class tblCountry
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}