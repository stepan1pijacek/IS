using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Data
{
    public partial class Faculty
    {
        public Faculty()
        {
            Students = new HashSet<Student>();
        }

        public decimal Id { get; set; }
        public string FacultyName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
