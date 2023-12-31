﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Configuration;

namespace StudentProfile.ViewModel
{
    public class StudentCreateModel
    {
        public StudentCreateModel()
        {
            DepartmentList = new List<SelectListItem>();
        }

        [Required]
        [RegularExpression("([A-Z*a-z]+)", ErrorMessage = "Please enter valid Name")]
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [Required]
        public DateTime AdmitionDate { get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Required]
        [DisplayName("Gender")]
        public Boolean IsGender { get; set; } = true;
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Contact Number")]
        public string Phone { get; set; }
        [Required]
        [DisplayName("CGPA")]
        public double Cgpa { get; set; }
        [Required]
        [DisplayName("Department")]
        public string Department { get; set; }

        [Required]
        public string Password { get; set; }

       
        public virtual IEnumerable<SelectListItem> DepartmentList { get; set; }
     
    }
}
