using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Data
{
    public partial class Subject
    {
        public Subject()
        {
            Scores = new HashSet<Score>();
        }

        public decimal Id { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
