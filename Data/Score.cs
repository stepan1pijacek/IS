using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Data
{
    public partial class Score
    {
        public decimal Id { get; set; }
        public decimal? StudentsId { get; set; }
        public decimal? SubjectId { get; set; }
        public decimal? Score1 { get; set; }

        public virtual Student Students { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
