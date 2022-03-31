﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentsEnrolled = new HashSet<StudentCourse>();
            this.HomeworkSubmissions = new HashSet<Homework>();
            this.Resources = new HashSet<Resource>();
        }

        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Homework> HomeworkSubmissions { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }

        public virtual ICollection<StudentCourse> StudentsEnrolled { get; set; }
    }
}
