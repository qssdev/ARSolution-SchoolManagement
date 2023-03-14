﻿using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class SubjectClass : IBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}