﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentProfile.ViewModel
{
    public class StudentEditModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [Required]
        public DateTime AdmitionDate { get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Required]
        public Boolean IsGender { get; set; }
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

        public string Gender
        {
            get
            {
                if (IsGender)
                {
                    return "Male";
                }
                else
                {
                    return "Female";
                }
            }
            set
            {

            }
        }
    }
}
