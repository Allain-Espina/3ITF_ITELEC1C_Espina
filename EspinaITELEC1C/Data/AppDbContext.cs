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

        }

    }
}
