using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IS.Data
{
    public partial class Faculty
    {
        public Faculty()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }
        public string FacultyName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
