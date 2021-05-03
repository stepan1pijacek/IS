using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IS.Data
{
    public partial class Subject
    {
        public Subject()
        {
            Scores = new HashSet<Score>();
        }

        [Key]
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
