using IS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS
{
    public class StudentsScore
    {
        public int? StudentsId { get; set; }
        public string StudentsName { get; set; }
        public string StudentsSurname { get; set; }
        public string FacultyName { get; set; }
        public string Subject { get; set; }
        public int StudentScore { get; set; }
    }
}
