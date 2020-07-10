using ProjectAPI.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Model.DataAccessLayer
{
    public partial class TblStudentDetails
    {
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }

        [EmailValidation(allowedDomain:"gmail.com",ErrorMessage ="Invalid Email Id")]
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}
