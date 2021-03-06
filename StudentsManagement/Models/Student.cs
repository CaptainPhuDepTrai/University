﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsManagement.Models
{
    public class Student:Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public String Major { get; set; } //khoa

        public String IRN { get; set; } //mssv
        public String PhoneNumber { get; set; } // phone

        public String Facebook { get; set; } // Facebook 

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
