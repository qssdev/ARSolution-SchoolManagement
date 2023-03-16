using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>().HasData(
                new People() { Id = 1, Email = "email1@email.com", Firstname = "Carla", Lastname = "Santos", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new People() { Id = 10, Email = "email2@email.com", Firstname = "James", Lastname = "Nobina", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new People() { Id = 11, Email = "email3@email.com", Firstname = "Matt", Lastname = "Mathew", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new People() { Id = 4, Email = "email4@email.com", Firstname = "Katt", Lastname = "Nevib", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new People() { Id = 5, Email = "email5@email.com", Firstname = "Sue", Lastname = "Chesdy", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new People() { Id = 12, Email = "email6@email.com", Firstname = "Paul", Lastname = "Juan", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new People() { Id = 7, Email = "email7@email.com", Firstname = "Jim", Lastname = "Greg", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now });

            modelBuilder.Entity<SubjectClass>().HasData(
                new SubjectClass() { Id = 1, Name = "English", Description = "English Vocabulary", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new SubjectClass() { Id = 2, Name = "Calculus", Description = "Mathematics", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new SubjectClass() { Id = 3, Name = "Music", Description = "ARTS", UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now }
                );
            modelBuilder.Entity<ProfessorClass>().HasData(
                new ProfessorClass() { Id = 1, ClassId = 1, ProfessorId = 10, StudentId = 1, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProfessorClass() { Id = 2, ClassId = 1, ProfessorId = 10, StudentId = 11, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProfessorClass() { Id = 3, ClassId = 1, ProfessorId = 10, StudentId = 4, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProfessorClass() { Id = 4, ClassId = 1, ProfessorId = 10, StudentId = 5, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProfessorClass() { Id = 5, ClassId = 1, ProfessorId = 10, StudentId = 12, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProfessorClass() { Id = 6, ClassId = 2, ProfessorId = 11, StudentId = 10, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProfessorClass() { Id = 7, ClassId = 2, ProfessorId = 11, StudentId = 1, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now }
                );

        }
    }
}
