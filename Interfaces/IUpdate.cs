using IS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS.Interfaces
{
    interface IUpdate
    {
        bool UpdateStudent(Student student);
        bool UpdateFaculty(Faculty faculty);
        bool UpdateSubject(Subject subject);
        bool UpdateScore(Score score);
    }
}
