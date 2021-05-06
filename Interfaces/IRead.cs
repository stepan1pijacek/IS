using IS.Data;
using IS.Helper;
using System.Collections.Generic;

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
        List<HelperGraphClass> studentsAVGperYear();
    }
}
