using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationPortel_3Octover26.Models
{
    public class tblCity
    {
        [Key]
        public int CityId { get; set; }
        public int stateId { get; set; }
        public string CityName { get; set; }
    }
}