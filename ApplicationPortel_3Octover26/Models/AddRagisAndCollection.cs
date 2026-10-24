using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationPortel_3Octover26.Models
{
    public class AddRagisAndCollection
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
        public int RDepartment { get; set; }
        [Required(ErrorMessage = "*")]
        public int RGender { get; set; }

        public string RHobbies { get; set; }
        [Required(ErrorMessage = "*")]
        public int RCountry { get; set; }
        [Required(ErrorMessage = "*")]
        public int RState { get; set; }
        [Required(ErrorMessage = "*")]
        public int RCity { get; set; }

        public string RResume { get; set; }

        public List<tblCountry> listcountries { get; set; }
        public List<tblState> liststate { get; set; }
        public List<tblCity> listcity { get; set; }
        public List<tblDepartment> listdepartments { get; set; }
        public List<hobbiesbind> listhobbies { get; set; }
        public List<tblGender> listgenders { get; set; }


    }
}