using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class Student
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z- ]{4,30}$")]
        [StringLength(30, MinimumLength =4, ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{2}-[0-9]{5}-[1-3]{1}$")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Please Enter Valid ID (Example: XX-XXXXX-X)")]
        public string ID { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z-]{3,10}$")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Please Enter UserName Between 3 and 10 Character")]
        public string UserName { get; set; }

        [RegularExpression(@"^[0-9]{2}-[0-9]{5}-[1-3]{1}@[a-zA-Z.]{16}$")]
        [Display(Name = "Please Enter Your Student Email Address (Example: XX-XXXXX-X@Student.aiub.edu)"), Required]
        public string Email { get; set; }


    }
}