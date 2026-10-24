using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationPortel_3Octover26.Models
{
    public class BindtblRegis1
    {
        [Key]
        public int RId { get; set; }
        [Required(ErrorMessage = "*")]
        public string RName { get; set; }
        [Required(ErrorMessage = "*")]
        public string REmail { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6)]
        public string RPassword { get; set; }
        [Required(ErrorMessage = "*")]
        public long RMobile { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RDob { get; set; }
        [Required(ErrorMessage = "*")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int RAge { get; set; }
        [Required(ErrorMessage = "*")]
        public string RDepartment { get; set; }
        [Required(ErrorMessage = "*")]
        public string RGender { get; set; }

        public string RHobbies { get; set; }
        [Required(ErrorMessage = "*")]
        public string RCountry { get; set; }
        [Required(ErrorMessage = "*")]
        public string RState { get; set; }
        [Required(ErrorMessage = "*")]
        public string RCity { get; set; }
        [Required(ErrorMessage = "*")]
        public string RResume { get; set; }
    }
}