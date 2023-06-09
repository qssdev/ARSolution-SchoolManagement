﻿using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class ProfessorClass : IBaseModel
    {
        [Key]
        public int Id { get; set; }
        public int ProfessorId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public People Professor { get; set; }
        public List<People> Students { get; set; }
    }
}