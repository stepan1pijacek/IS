using IS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Interfaces
{
    interface IRead
    {
        List<object> studentsFaculty();
        List<object> studentsScore();
        List<Score> scores();
        List<Faculty> faculties();
        List<Subject> subjects();
        List<Student> students();
    }
}
