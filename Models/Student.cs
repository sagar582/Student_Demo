using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Demo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        
        [Display(Name = "Name")]
        [Required]
        public string StudentName { get; set; }

        [Range(15,25)]
        public int Age { get; set; }

        [Required]
        public string Description { get; set; }
        public bool isActive { get; set; }
        /*public string Gender { get; set; }*/
        public string StudentGender { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }


    }

    public enum Gender
    {
        Male,
        Female
    }
}