using Microsoft.EntityFrameworkCore;
using System;

namespace IS.Data
{
    public class ISDbContext : DbContext
    {
        public ISDbContext()
        {

        }
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=IS;Trusted_Connection=True;");

            }
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
