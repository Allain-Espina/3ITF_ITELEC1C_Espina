using System;
using Microsoft.EntityFrameworkCore;
using EspinaITELEC1C.Models;
namespace EspinaITELEC1C.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<InstructorModel> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //do not remove this code snippet

            modelBuilder.Entity<StudentModel>().HasData(
                new StudentModel
                {
                    StudentId = 1,
                    StudentName = "Allain Espina",
                    GeneralWeightedAverage = 1.25,
                    DateEnrolled = DateTime.Now,
                    StudentCourse = Course.BSIT,
                    StudentEmail = "allain.espina.cics@ust.edu.ph"
                },
                    new StudentModel
                    {
                        StudentId = 2,
                        StudentName = "Daniel Espina",
                        GeneralWeightedAverage = 1.5,
                        DateEnrolled = DateTime.Now,
                        StudentCourse = Course.BSCS,
                        StudentEmail = "daniel.espina.cics@ust.edu.ph"
                    },
                    new StudentModel
                    {
                        StudentId = 3,
                        StudentName = "Sanoy Espina",
                        GeneralWeightedAverage = 1.75,
                        DateEnrolled = DateTime.Now,
                        StudentCourse = Course.BSIS,
                        StudentEmail = "sanoy.espina.cics@ust.edu.ph"
                    }
                    );

                modelBuilder.Entity<InstructorModel>().HasData(
                    new InstructorModel
                    {
                        Id = 1,
                        FirstName = "Allain",
                        LastName = "Espina",
                        IsTenured = true,
                        Rank = Ranks.AssociateProfessor,
                        HiringDate = DateTime.Parse("06/1/2023").Date,
                        Email = "a@gmail.com",
                        Phone = "02-123-4567"
                    },
                    new InstructorModel
                    {
                        Id = 2,
                        FirstName = "Allen",
                        LastName = "De Juan",
                        IsTenured = true,
                        Rank = Ranks.Professor,
                        HiringDate = DateTime.Parse("07/2/2023").Date,
                        Email = "b@gmail.com",
                        Phone = "02-123-4567"
                    },
                    new InstructorModel
                    {
                        Id = 3,
                        FirstName = "Aira",
                        LastName = "Cruz",
                        IsTenured = false,
                        Rank = Ranks.AssistantProfessor,
                        HiringDate = DateTime.Parse("08/3/2023").Date,
                        Email = "c@gmail.com",
                        Phone = "02-123-4567"
                    },
                     new InstructorModel
                     {
                         Id = 4,
                         FirstName = "Jesmith",
                         LastName = "Simbulan",
                         IsTenured = false,
                         Rank = Ranks.Instructor,
                         HiringDate = DateTime.Parse("09/4/2023").Date,
                         Email = "d@gmail.com",
                         Phone = "02-123-4567"
                     }
                    );

        }

    }
}
