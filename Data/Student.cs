using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Data
{
    public partial class Student
    {
        public Student()
        {
            Scores = new HashSet<Score>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public decimal? Phone { get; set; }
        public decimal? Year { get; set; }
        public decimal? FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
