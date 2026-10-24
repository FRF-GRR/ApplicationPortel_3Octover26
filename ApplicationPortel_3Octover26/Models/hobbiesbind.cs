using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationPortel_3Octover26.Models
{
    public class hobbiesbind
    {
        [Key]
        public int HobbiesId { get; set; }
        public bool ischeked { get; set; }
        public string HobbiesName { get; set; }
    }
}