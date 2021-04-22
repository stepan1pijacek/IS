using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Data
{
    public class ISDbContext : DbContext
    {
        public ISDbContext(DbContextOptions<ISDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(getStudents());
            modelBuilder.Entity<Faculty>().HasData(getFaculty());
            base.OnModelCreating(modelBuilder);
        }
        private Faculty[] getFaculty()
        {
            return new Faculty[]
            {
                new Faculty{Id = 1, FacultyName = "FEKT" }
            };
        }

        private Student[] getStudents()
        {
            return new Student[]
            {
                new Student{Id = 1, Name = "Igor", Surname = "Golian", DateOfBirth = Convert.ToDateTime("4.1.2000"), Email = "golian@seznam.cz", Phone = 734220456, Year = 2021, FacultyId = 1}
            };
        }
    }
}
