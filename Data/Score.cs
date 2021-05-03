using System.ComponentModel.DataAnnotations;

namespace IS.Data
{
    public partial class Score
    {
        [Key]
        public int Id { get; set; }
        public int? StudentsId { get; set; }
        public int? SubjectId { get; set; }
        public int? Score1 { get; set; }

        public virtual Student Students { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
