using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IS.Data
{
    public partial class Student
    {
        public Student()
        {
            Scores = new HashSet<Score>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime? DateOfBirth { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public int? Phone { get; set; }
        public int? Year { get; set; }
        public int? FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
