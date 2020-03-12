﻿using System.ComponentModel.DataAnnotations;
using VirtualDeanary.Data.Models;
using VirtualDeanery.Data.Models;

namespace VirtualDeanary.Models
{
    public class AddCourseViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }

        public int SemesterId { get; set; }
        public Semester Semester { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; } //Properties for Teacher
    }
}

